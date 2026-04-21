using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBP.Controls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    internal class CustomCombobox : UserControl
    {
        //fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;
        private bool readOnlyWhiteMode = false;

        //items
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;
        private bool isSearchable = false;

        //properties
        [Category("Custom ComboBox")]
        public new Color BackColor { get => backColor; set { backColor = value; lblText.BackColor = backColor; btnIcon.BackColor = backColor; } }
        [Category("Custom ComboBox")]
        public Color IconColor { get => iconColor; set { iconColor = value; btnIcon.Invalidate(); } }
        [Category("Custom ComboBox")]
        public Color ListBackColor { get => listBackColor; set { listBackColor = value; cmbList.BackColor = listBackColor; } }
        [Category("Custom ComboBox")]
        public Color ListTextColor { get => listTextColor; set { listTextColor = value; cmbList.ForeColor = listTextColor; } }
        [Category("Custom ComboBox")]
        public Color BorderColor { get => borderColor; set { borderColor = value; base.BackColor = borderColor; } }
        [Category("Custom ComboBox")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Padding = new Padding(borderSize); AdjustComboBoxDimensions(); } }
        
        [Category("Custom ComboBox")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set 
            { 
                base.ForeColor = value; 
                if (this.Enabled) lblText.ForeColor = value; 
            }
        }
        
        [Category("Custom ComboBox")]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; lblText.Font = value; }
        }
        
        [Category("Custom ComboBox")]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; lblText.Text = value; }
        }
        
        [Category("Custom ComboBox")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set { if (cmbList.DropDownStyle != ComboBoxStyle.Simple) cmbList.DropDownStyle = value; }
        }

        [Category("Custom ComboBox")]
        public string DisplayMember
        {
            get { return cmbList.DisplayMember; }
            set { cmbList.DisplayMember = value; }
        }

        [Category("Custom ComboBox")]
        public string ValueMember
        {
            get { return cmbList.ValueMember; }
            set { cmbList.ValueMember = value; }
        }

        [Category("Custom ComboBox")]
        [Browsable(false)]
        public object SelectedValue
        {
            get { return cmbList.SelectedValue; }
            set { cmbList.SelectedValue = value; }
        }

        [Category("Custom ComboBox")]
        public bool ReadOnlyWhiteMode { get => readOnlyWhiteMode; set => readOnlyWhiteMode = value; }

        [Category("Custom ComboBox")]
        public bool IsSearchable
        {
            get => isSearchable;
            set
            {
                isSearchable = value;
                if (isSearchable)
                {
                    cmbList.DropDownStyle = ComboBoxStyle.DropDown;
                    cmbList.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cmbList.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cmbList.FlatStyle = FlatStyle.Flat;
                    cmbList.BackColor = this.BackColor;
                    cmbList.ForeColor = this.ForeColor;
                    lblText.Visible = false;
                    cmbList.Visible = true;
                    AdjustComboBoxDimensions();
                    cmbList.BringToFront();
                    btnIcon.BringToFront(); // Ensure custom arrow is on top
                }
                else
                {
                    cmbList.DropDownStyle = ComboBoxStyle.DropDownList;
                    lblText.Visible = true;
                    cmbList.Dock = DockStyle.None;
                    AdjustComboBoxDimensions();
                }
            }
        }

        [Category("Custom ComboBox")]
        public bool IsReadOnly
        {
            get => !cmbList.Enabled;
            set
            {
                cmbList.Enabled = !value;
                btnIcon.Enabled = !value;
                
                if (isSearchable)
                {
                    if (value) // ReadOnly
                    {
                        lblText.Visible = true;
                        cmbList.Visible = false;
                        lblText.Text = cmbList.Text;
                    }
                    else // Editable
                    {
                        lblText.Visible = false;
                        cmbList.Visible = true;
                        cmbList.BringToFront();
                        btnIcon.BringToFront();
                    }
                }

                if (value)
                {
                    lblText.BackColor = Color.FromArgb(32, 30, 45); // Match form background
                    lblText.ForeColor = readOnlyWhiteMode ? Color.White : Color.Gray;
                }
                else
                {
                    lblText.BackColor = this.BackColor;
                    lblText.ForeColor = this.ForeColor;
                }
            }
        }

        //Data
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items { get => cmbList.Items; }

        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public object DataSource { get => cmbList.DataSource; set => cmbList.DataSource = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource { get => cmbList.AutoCompleteCustomSource; set => cmbList.AutoCompleteCustomSource = value; }

        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource { get => cmbList.AutoCompleteSource; set => cmbList.AutoCompleteSource = value; }

        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode { get => cmbList.AutoCompleteMode; set => cmbList.AutoCompleteMode = value; }

        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem { get => cmbList.SelectedItem; set => cmbList.SelectedItem = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex { get => cmbList.SelectedIndex; set => cmbList.SelectedIndex = value; }

        public string GetItemText(object item)
        {
            return cmbList.GetItemText(item);
        }

        //Events
        public event EventHandler OnSelectedIndexChanged;

        //Constructor
        public CustomCombobox()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();

            //Combobox: Dropdown list
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(cmbList_SelectedIndexChanged);
            cmbList.TextChanged += new EventHandler(cmbList_TextChanged);

            //Button: Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(btnIcon_Click);
            btnIcon.Paint += new PaintEventHandler(btnIcon_Paint);

            //Label: Text
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Font = new Font(this.Font.Name, 10);
            lblText.BackColor = backColor;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Click += new EventHandler(Surface_Click);
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            //User Control
            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            if (isSearchable)
            {
                // Fit within padding and use Region to hide the native arrow
                cmbList.Width = this.Width - this.Padding.Horizontal;
                cmbList.Location = new Point()
                {
                    X = this.Padding.Left,
                    Y = (this.Height - cmbList.Height) / 2
                };
                
                // Clip the right part of the native combobox where the arrow is
                // but keep enough space for the custom arrow button to sit on top
                int clipWidth = cmbList.Width - 18; 
                if (clipWidth > 0)
                {
                    cmbList.Region = new Region(new Rectangle(0, 0, clipWidth, cmbList.Height));
                }
            }
            else
            {
                cmbList.Region = null; // Reset region for normal mode
                cmbList.Width = lblText.Width;
                cmbList.Location = new Point()
                {
                    X = this.Width - this.Padding.Right - cmbList.Width,
                    Y = lblText.Bottom - cmbList.Height
                };
            }
        }

        //Event methods
        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            if (this.IsReadOnly || !this.Enabled) return;
            cmbList.Select();
            if (cmbList.DroppedDown == false) cmbList.DroppedDown = true;
        }

        private void btnIcon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle()
            {
                X = (btnIcon.Width - iconWidth) / 2,
                Y = (btnIcon.Height - iconHeight) / 2,
                Width = iconWidth,
                Height = iconHeight
            };
            Graphics graph = e.Graphics;
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + rectIcon.Width / 2, rectIcon.Bottom);
                path.AddLine(rectIcon.X + rectIcon.Width / 2, rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            if (this.IsReadOnly || !this.Enabled) return;
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void cmbList_TextChanged(object sender, EventArgs e) { lblText.Text = cmbList.Text; }

        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectedIndexChanged?.Invoke(sender, e);
            lblText.Text = cmbList.Text;
        }

        private void Surface_MouseLeave(object sender, EventArgs e) { this.OnMouseLeave(e); }
        private void Surface_MouseEnter(object sender, EventArgs e) { this.OnMouseEnter(e); }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (this.Enabled) lblText.ForeColor = this.ForeColor;
            else lblText.ForeColor = Color.Gray; // Màu xám cho trạng thái disabled thông thường
            lblText.Invalidate();
        }
    }
}
