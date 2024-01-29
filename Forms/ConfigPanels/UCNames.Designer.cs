using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GenieClient
{
    [DesignerGenerated()]
    public partial class UCName : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCName));
            _ListViewBase = new ListView();
            _ContextMenuStripBase = new ContextMenuStrip(components);
            _AddToolStripMenuItem = new ToolStripMenuItem();
            _RemoveToolStripMenuItem = new ToolStripMenuItem();
            _GroupBoxBase = new GroupBox();
            _ButtonColorBg = new Button();
            _LabelExampleColor = new Label();
            _ButtonColorFg = new Button();
            _LabelColor = new Label();
            _TextBoxName = new TextBox();
            _LabelAlias = new Label();
            _ButtonApply = new Button();
            _TextBoxColor = new TextBox();
            _ColorDialogPicker = new ColorDialog();
            _ToolStripMenu = new ToolStrip();
            _ToolStripButtonRefresh = new ToolStripButton();
            _ToolStripSeparator2 = new ToolStripSeparator();
            _ToolStripButtonAdd = new ToolStripButton();
            _ToolStripButtonRemove = new ToolStripButton();
            _ToolStripSeparator1 = new ToolStripSeparator();
            _ToolStripButtonLoad = new ToolStripButton();
            _ToolStripButtonSave = new ToolStripButton();
            _ContextMenuStripBase.SuspendLayout();
            _GroupBoxBase.SuspendLayout();
            _ToolStripMenu.SuspendLayout();
            SuspendLayout();
            // 
            // _ListViewBase
            // 
            _ListViewBase.BackColor = Color.Black;
            _ListViewBase.ContextMenuStrip = _ContextMenuStripBase;
            _ListViewBase.Dock = DockStyle.Fill;
            _ListViewBase.ForeColor = Color.White;
            _ListViewBase.FullRowSelect = true;
            _ListViewBase.Location = new Point(0, 25);
            _ListViewBase.Margin = new Padding(4, 3, 4, 3);
            _ListViewBase.Name = "_ListViewBase";
            _ListViewBase.ShowGroups = false;
            _ListViewBase.Size = new Size(814, 364);
            _ListViewBase.Sorting = SortOrder.Ascending;
            _ListViewBase.TabIndex = 0;
            _ListViewBase.UseCompatibleStateImageBehavior = false;
            _ListViewBase.View = View.Details;
            _ListViewBase.ColumnClick += ListViewBase_SortColumnClick;
            _ListViewBase.SelectedIndexChanged += ListViewBase_SelectedIndexChanged;
            _ListViewBase.KeyUp += ListViewBase_KeyUp;
            _ListViewBase.MouseUp += ListViewBase_MouseUp;
            // 
            // _ContextMenuStripBase
            // 
            _ContextMenuStripBase.Items.AddRange(new ToolStripItem[] { _AddToolStripMenuItem, _RemoveToolStripMenuItem });
            _ContextMenuStripBase.Name = "ContextMenuStripBase";
            _ContextMenuStripBase.Size = new Size(118, 48);
            // 
            // _AddToolStripMenuItem
            // 
            _AddToolStripMenuItem.Name = "_AddToolStripMenuItem";
            _AddToolStripMenuItem.Size = new Size(117, 22);
            _AddToolStripMenuItem.Text = "Add";
            _AddToolStripMenuItem.Click += AddToolStripMenuItem_Click;
            // 
            // _RemoveToolStripMenuItem
            // 
            _RemoveToolStripMenuItem.Enabled = false;
            _RemoveToolStripMenuItem.Name = "_RemoveToolStripMenuItem";
            _RemoveToolStripMenuItem.Size = new Size(117, 22);
            _RemoveToolStripMenuItem.Text = "Remove";
            _RemoveToolStripMenuItem.Click += RemoveToolStripMenuItem_Click;
            // 
            // _GroupBoxBase
            // 
            _GroupBoxBase.AutoSize = true;
            _GroupBoxBase.Controls.Add(_ButtonColorBg);
            _GroupBoxBase.Controls.Add(_LabelExampleColor);
            _GroupBoxBase.Controls.Add(_ButtonColorFg);
            _GroupBoxBase.Controls.Add(_LabelColor);
            _GroupBoxBase.Controls.Add(_TextBoxName);
            _GroupBoxBase.Controls.Add(_LabelAlias);
            _GroupBoxBase.Controls.Add(_ButtonApply);
            _GroupBoxBase.Controls.Add(_TextBoxColor);
            _GroupBoxBase.Dock = DockStyle.Bottom;
            _GroupBoxBase.Enabled = false;
            _GroupBoxBase.Location = new Point(0, 389);
            _GroupBoxBase.Margin = new Padding(4, 3, 4, 3);
            _GroupBoxBase.Name = "_GroupBoxBase";
            _GroupBoxBase.Padding = new Padding(4, 3, 4, 3);
            _GroupBoxBase.Size = new Size(814, 126);
            _GroupBoxBase.TabIndex = 2;
            _GroupBoxBase.TabStop = false;
            // 
            // _ButtonColorBg
            // 
            _ButtonColorBg.Image = (Image)resources.GetObject("_ButtonColorBg.Image");
            _ButtonColorBg.Location = new Point(491, 36);
            _ButtonColorBg.Margin = new Padding(4, 3, 4, 3);
            _ButtonColorBg.Name = "_ButtonColorBg";
            _ButtonColorBg.Size = new Size(27, 27);
            _ButtonColorBg.TabIndex = 12;
            _ButtonColorBg.UseVisualStyleBackColor = true;
            _ButtonColorBg.Click += ButtonColorBg_Click;
            // 
            // _LabelExampleColor
            // 
            _LabelExampleColor.BackColor = Color.Black;
            _LabelExampleColor.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _LabelExampleColor.ForeColor = Color.Black;
            _LabelExampleColor.Location = new Point(376, 37);
            _LabelExampleColor.Margin = new Padding(4, 0, 4, 0);
            _LabelExampleColor.Name = "_LabelExampleColor";
            _LabelExampleColor.Size = new Size(75, 23);
            _LabelExampleColor.TabIndex = 11;
            _LabelExampleColor.Text = "Color";
            _LabelExampleColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _ButtonColorFg
            // 
            _ButtonColorFg.Image = (Image)resources.GetObject("_ButtonColorFg.Image");
            _ButtonColorFg.Location = new Point(457, 36);
            _ButtonColorFg.Margin = new Padding(4, 3, 4, 3);
            _ButtonColorFg.Name = "_ButtonColorFg";
            _ButtonColorFg.Size = new Size(27, 27);
            _ButtonColorFg.TabIndex = 3;
            _ButtonColorFg.UseVisualStyleBackColor = true;
            _ButtonColorFg.Click += ButtonColorFg_Click;
            // 
            // _LabelColor
            // 
            _LabelColor.AutoSize = true;
            _LabelColor.Location = new Point(188, 18);
            _LabelColor.Margin = new Padding(4, 0, 4, 0);
            _LabelColor.Name = "_LabelColor";
            _LabelColor.Size = new Size(36, 15);
            _LabelColor.TabIndex = 10;
            _LabelColor.Text = "Color";
            // 
            // _TextBoxName
            // 
            _TextBoxName.Location = new Point(7, 37);
            _TextBoxName.Margin = new Padding(4, 3, 4, 3);
            _TextBoxName.Name = "_TextBoxName";
            _TextBoxName.Size = new Size(177, 23);
            _TextBoxName.TabIndex = 0;
            _TextBoxName.TextChanged += TextBox_TextChanged;
            // 
            // _LabelAlias
            // 
            _LabelAlias.AutoSize = true;
            _LabelAlias.Location = new Point(4, 18);
            _LabelAlias.Margin = new Padding(4, 0, 4, 0);
            _LabelAlias.Name = "_LabelAlias";
            _LabelAlias.Size = new Size(39, 15);
            _LabelAlias.TabIndex = 8;
            _LabelAlias.Text = "Name";
            // 
            // _ButtonApply
            // 
            _ButtonApply.Location = new Point(7, 77);
            _ButtonApply.Margin = new Padding(4, 3, 4, 3);
            _ButtonApply.Name = "_ButtonApply";
            _ButtonApply.Size = new Size(88, 27);
            _ButtonApply.TabIndex = 2;
            _ButtonApply.Text = "Apply";
            _ButtonApply.UseVisualStyleBackColor = true;
            _ButtonApply.Click += ButtonApply_Click;
            // 
            // _TextBoxColor
            // 
            _TextBoxColor.Location = new Point(191, 37);
            _TextBoxColor.Margin = new Padding(4, 3, 4, 3);
            _TextBoxColor.Name = "_TextBoxColor";
            _TextBoxColor.Size = new Size(177, 23);
            _TextBoxColor.TabIndex = 1;
            _TextBoxColor.TextChanged += TextBox_TextChanged;
            _TextBoxColor.KeyDown += TextBoxColor_KeyDown;
            _TextBoxColor.Leave += TextBoxColor_Leave;
            // 
            // _ColorDialogPicker
            // 
            _ColorDialogPicker.FullOpen = true;
            // 
            // _ToolStripMenu
            // 
            _ToolStripMenu.AllowMerge = false;
            _ToolStripMenu.GripStyle = ToolStripGripStyle.Hidden;
            _ToolStripMenu.Items.AddRange(new ToolStripItem[] { _ToolStripButtonRefresh, _ToolStripSeparator2, _ToolStripButtonAdd, _ToolStripButtonRemove, _ToolStripSeparator1, _ToolStripButtonLoad, _ToolStripButtonSave });
            _ToolStripMenu.Location = new Point(0, 0);
            _ToolStripMenu.Name = "_ToolStripMenu";
            _ToolStripMenu.Size = new Size(814, 25);
            _ToolStripMenu.TabIndex = 6;
            // 
            // _ToolStripButtonRefresh
            // 
            _ToolStripButtonRefresh.ImageTransparentColor = Color.Magenta;
            _ToolStripButtonRefresh.Name = "_ToolStripButtonRefresh";
            _ToolStripButtonRefresh.Size = new Size(50, 22);
            _ToolStripButtonRefresh.Text = "Refresh";
            // 
            // _ToolStripSeparator2
            // 
            _ToolStripSeparator2.Name = "_ToolStripSeparator2";
            _ToolStripSeparator2.Size = new Size(6, 25);
            // 
            // _ToolStripButtonAdd
            // 
            _ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            _ToolStripButtonAdd.Name = "_ToolStripButtonAdd";
            _ToolStripButtonAdd.Size = new Size(33, 22);
            _ToolStripButtonAdd.Text = "Add";
            _ToolStripButtonAdd.Click += ToolStripButtonAdd_Click;
            // 
            // _ToolStripButtonRemove
            // 
            _ToolStripButtonRemove.Enabled = false;
            _ToolStripButtonRemove.ImageTransparentColor = Color.Magenta;
            _ToolStripButtonRemove.Name = "_ToolStripButtonRemove";
            _ToolStripButtonRemove.Size = new Size(54, 22);
            _ToolStripButtonRemove.Text = "Remove";
            _ToolStripButtonRemove.Click += ToolStripButtonRemove_Click;
            // 
            // _ToolStripSeparator1
            // 
            _ToolStripSeparator1.Name = "_ToolStripSeparator1";
            _ToolStripSeparator1.Size = new Size(6, 25);
            // 
            // _ToolStripButtonLoad
            // 
            _ToolStripButtonLoad.ImageTransparentColor = Color.Magenta;
            _ToolStripButtonLoad.Name = "_ToolStripButtonLoad";
            _ToolStripButtonLoad.Size = new Size(37, 22);
            _ToolStripButtonLoad.Text = "Load";
            _ToolStripButtonLoad.Click += ToolStripButtonLoad_Click;
            // 
            // _ToolStripButtonSave
            // 
            _ToolStripButtonSave.ImageTransparentColor = Color.Magenta;
            _ToolStripButtonSave.Name = "_ToolStripButtonSave";
            _ToolStripButtonSave.Size = new Size(35, 22);
            _ToolStripButtonSave.Text = "Save";
            _ToolStripButtonSave.Click += ToolStripButtonSave_Click;
            // 
            // UCName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_ListViewBase);
            Controls.Add(_GroupBoxBase);
            Controls.Add(_ToolStripMenu);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UCName";
            Size = new Size(814, 515);
            Load += UCWindows_Load;
            _ContextMenuStripBase.ResumeLayout(false);
            _GroupBoxBase.ResumeLayout(false);
            _GroupBoxBase.PerformLayout();
            _ToolStripMenu.ResumeLayout(false);
            _ToolStripMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ListView _ListViewBase;

        internal ListView ListViewBase
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewBase;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewBase != null)
                {
                    _ListViewBase.KeyUp -= ListViewBase_KeyUp;
                    _ListViewBase.MouseUp -= ListViewBase_MouseUp;
                    _ListViewBase.SelectedIndexChanged -= ListViewBase_SelectedIndexChanged;
                }

                _ListViewBase = value;
                if (_ListViewBase != null)
                {
                    _ListViewBase.KeyUp += ListViewBase_KeyUp;
                    _ListViewBase.MouseUp += ListViewBase_MouseUp;
                    _ListViewBase.SelectedIndexChanged += ListViewBase_SelectedIndexChanged;
                }
            }
        }

        private GroupBox _GroupBoxBase;

        internal GroupBox GroupBoxBase
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBoxBase;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBoxBase != null)
                {
                }

                _GroupBoxBase = value;
                if (_GroupBoxBase != null)
                {
                }
            }
        }

        private Label _LabelColor;

        internal Label LabelColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelColor != null)
                {
                }

                _LabelColor = value;
                if (_LabelColor != null)
                {
                }
            }
        }

        private TextBox _TextBoxName;

        internal TextBox TextBoxName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxName != null)
                {
                    _TextBoxName.TextChanged -= TextBox_TextChanged;
                }

                _TextBoxName = value;
                if (_TextBoxName != null)
                {
                    _TextBoxName.TextChanged += TextBox_TextChanged;
                }
            }
        }

        private Label _LabelAlias;

        internal Label LabelAlias
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelAlias;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelAlias != null)
                {
                }

                _LabelAlias = value;
                if (_LabelAlias != null)
                {
                }
            }
        }

        private Button _ButtonApply;

        internal Button ButtonApply
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonApply;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonApply != null)
                {
                    _ButtonApply.Click -= ButtonApply_Click;
                }

                _ButtonApply = value;
                if (_ButtonApply != null)
                {
                    _ButtonApply.Click += ButtonApply_Click;
                }
            }
        }

        private TextBox _TextBoxColor;

        internal TextBox TextBoxColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxColor != null)
                {
                    _TextBoxColor.KeyDown -= TextBoxColor_KeyDown;
                    _TextBoxColor.Leave -= TextBoxColor_Leave;
                    _TextBoxColor.TextChanged -= TextBox_TextChanged;
                }

                _TextBoxColor = value;
                if (_TextBoxColor != null)
                {
                    _TextBoxColor.KeyDown += TextBoxColor_KeyDown;
                    _TextBoxColor.Leave += TextBoxColor_Leave;
                    _TextBoxColor.TextChanged += TextBox_TextChanged;
                }
            }
        }

        private ColorDialog _ColorDialogPicker;

        internal ColorDialog ColorDialogPicker
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColorDialogPicker;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColorDialogPicker != null)
                {
                }

                _ColorDialogPicker = value;
                if (_ColorDialogPicker != null)
                {
                }
            }
        }

        private Button _ButtonColorFg;

        internal Button ButtonColorFg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonColorFg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonColorFg != null)
                {
                    _ButtonColorFg.Click -= ButtonColorFg_Click;
                }

                _ButtonColorFg = value;
                if (_ButtonColorFg != null)
                {
                    _ButtonColorFg.Click += ButtonColorFg_Click;
                }
            }
        }

        private Label _LabelExampleColor;

        internal Label LabelExampleColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelExampleColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelExampleColor != null)
                {
                }

                _LabelExampleColor = value;
                if (_LabelExampleColor != null)
                {
                }
            }
        }

        private Button _ButtonColorBg;

        internal Button ButtonColorBg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonColorBg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonColorBg != null)
                {
                    _ButtonColorBg.Click -= ButtonColorBg_Click;
                }

                _ButtonColorBg = value;
                if (_ButtonColorBg != null)
                {
                    _ButtonColorBg.Click += ButtonColorBg_Click;
                }
            }
        }

        private ToolStrip _ToolStripMenu;

        internal ToolStrip ToolStripMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripMenu != null)
                {
                }

                _ToolStripMenu = value;
                if (_ToolStripMenu != null)
                {
                }
            }
        }

        private ToolStripButton _ToolStripButtonRefresh;

        internal ToolStripButton ToolStripButtonRefresh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButtonRefresh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButtonRefresh != null)
                {
                }

                _ToolStripButtonRefresh = value;
                if (_ToolStripButtonRefresh != null)
                {
                }
            }
        }

        private ToolStripSeparator _ToolStripSeparator2;

        internal ToolStripSeparator ToolStripSeparator2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripSeparator2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripSeparator2 != null)
                {
                }

                _ToolStripSeparator2 = value;
                if (_ToolStripSeparator2 != null)
                {
                }
            }
        }

        private ToolStripButton _ToolStripButtonAdd;

        internal ToolStripButton ToolStripButtonAdd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButtonAdd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButtonAdd != null)
                {
                    _ToolStripButtonAdd.Click -= ToolStripButtonAdd_Click;
                }

                _ToolStripButtonAdd = value;
                if (_ToolStripButtonAdd != null)
                {
                    _ToolStripButtonAdd.Click += ToolStripButtonAdd_Click;
                }
            }
        }

        private ToolStripButton _ToolStripButtonRemove;

        internal ToolStripButton ToolStripButtonRemove
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButtonRemove;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButtonRemove != null)
                {
                    _ToolStripButtonRemove.Click -= ToolStripButtonRemove_Click;
                }

                _ToolStripButtonRemove = value;
                if (_ToolStripButtonRemove != null)
                {
                    _ToolStripButtonRemove.Click += ToolStripButtonRemove_Click;
                }
            }
        }

        private ToolStripSeparator _ToolStripSeparator1;

        internal ToolStripSeparator ToolStripSeparator1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripSeparator1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripSeparator1 != null)
                {
                }

                _ToolStripSeparator1 = value;
                if (_ToolStripSeparator1 != null)
                {
                }
            }
        }

        private ToolStripButton _ToolStripButtonLoad;

        internal ToolStripButton ToolStripButtonLoad
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButtonLoad;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButtonLoad != null)
                {
                    _ToolStripButtonLoad.Click -= ToolStripButtonLoad_Click;
                }

                _ToolStripButtonLoad = value;
                if (_ToolStripButtonLoad != null)
                {
                    _ToolStripButtonLoad.Click += ToolStripButtonLoad_Click;
                }
            }
        }

        private ToolStripButton _ToolStripButtonSave;

        internal ToolStripButton ToolStripButtonSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripButtonSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolStripButtonSave != null)
                {
                    _ToolStripButtonSave.Click -= ToolStripButtonSave_Click;
                }

                _ToolStripButtonSave = value;
                if (_ToolStripButtonSave != null)
                {
                    _ToolStripButtonSave.Click += ToolStripButtonSave_Click;
                }
            }
        }

        private ContextMenuStrip _ContextMenuStripBase;

        internal ContextMenuStrip ContextMenuStripBase
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ContextMenuStripBase;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ContextMenuStripBase != null)
                {
                }

                _ContextMenuStripBase = value;
                if (_ContextMenuStripBase != null)
                {
                }
            }
        }

        private ToolStripMenuItem _AddToolStripMenuItem;

        internal ToolStripMenuItem AddToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AddToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AddToolStripMenuItem != null)
                {
                    _AddToolStripMenuItem.Click -= AddToolStripMenuItem_Click;
                }

                _AddToolStripMenuItem = value;
                if (_AddToolStripMenuItem != null)
                {
                    _AddToolStripMenuItem.Click += AddToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _RemoveToolStripMenuItem;

        internal ToolStripMenuItem RemoveToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RemoveToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RemoveToolStripMenuItem != null)
                {
                    _RemoveToolStripMenuItem.Click -= RemoveToolStripMenuItem_Click;
                }

                _RemoveToolStripMenuItem = value;
                if (_RemoveToolStripMenuItem != null)
                {
                    _RemoveToolStripMenuItem.Click += RemoveToolStripMenuItem_Click;
                }
            }
        }
    }
}