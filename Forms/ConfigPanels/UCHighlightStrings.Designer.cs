using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GenieClient
{
    [DesignerGenerated()]
    public partial class UCHighlightStrings : UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHighlightStrings));
            _ListViewBase = new ListView();
            _ContextMenuStripBase = new ContextMenuStrip(components);
            _AddToolStripMenuItem = new ToolStripMenuItem();
            _RemoveToolStripMenuItem = new ToolStripMenuItem();
            _GroupBoxBase = new GroupBox();
            _ButtonPlay = new Button();
            _ButtonBrowse = new Button();
            _TextBoxSound = new TextBox();
            _LabelSound = new Label();
            _LabelClass = new Label();
            _ComboBoxClass = new ComboBox();
            _CheckBoxAutoApply = new CheckBox();
            _RadioButtonRegExp = new RadioButton();
            _RadioButtonBeginsWith = new RadioButton();
            _CheckBoxCaseSensitive = new CheckBox();
            _RadioButtonLine = new RadioButton();
            _RadioButtonString = new RadioButton();
            _ButtonColorBg = new Button();
            _LabelExampleColor = new Label();
            _ButtonColorFg = new Button();
            _LabelColor = new Label();
            _TextBoxHighlight = new TextBox();
            _LabelHighlight = new Label();
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
            _OpenFileDialogSound = new OpenFileDialog();
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
            _ListViewBase.Size = new Size(814, 255);
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
            _GroupBoxBase.Controls.Add(_ButtonPlay);
            _GroupBoxBase.Controls.Add(_ButtonBrowse);
            _GroupBoxBase.Controls.Add(_TextBoxSound);
            _GroupBoxBase.Controls.Add(_LabelSound);
            _GroupBoxBase.Controls.Add(_LabelClass);
            _GroupBoxBase.Controls.Add(_ComboBoxClass);
            _GroupBoxBase.Controls.Add(_CheckBoxAutoApply);
            _GroupBoxBase.Controls.Add(_RadioButtonRegExp);
            _GroupBoxBase.Controls.Add(_RadioButtonBeginsWith);
            _GroupBoxBase.Controls.Add(_CheckBoxCaseSensitive);
            _GroupBoxBase.Controls.Add(_RadioButtonLine);
            _GroupBoxBase.Controls.Add(_RadioButtonString);
            _GroupBoxBase.Controls.Add(_ButtonColorBg);
            _GroupBoxBase.Controls.Add(_LabelExampleColor);
            _GroupBoxBase.Controls.Add(_ButtonColorFg);
            _GroupBoxBase.Controls.Add(_LabelColor);
            _GroupBoxBase.Controls.Add(_TextBoxHighlight);
            _GroupBoxBase.Controls.Add(_LabelHighlight);
            _GroupBoxBase.Controls.Add(_ButtonApply);
            _GroupBoxBase.Controls.Add(_TextBoxColor);
            _GroupBoxBase.Dock = DockStyle.Bottom;
            _GroupBoxBase.Enabled = false;
            _GroupBoxBase.Location = new Point(0, 280);
            _GroupBoxBase.Margin = new Padding(4, 3, 4, 3);
            _GroupBoxBase.Name = "_GroupBoxBase";
            _GroupBoxBase.Padding = new Padding(4, 3, 4, 3);
            _GroupBoxBase.Size = new Size(814, 235);
            _GroupBoxBase.TabIndex = 1;
            _GroupBoxBase.TabStop = false;
            // 
            // _ButtonPlay
            // 
            _ButtonPlay.Image = (Image)resources.GetObject("_ButtonPlay.Image");
            _ButtonPlay.Location = new Point(383, 153);
            _ButtonPlay.Margin = new Padding(4, 3, 4, 3);
            _ButtonPlay.Name = "_ButtonPlay";
            _ButtonPlay.Size = new Size(27, 27);
            _ButtonPlay.TabIndex = 12;
            _ButtonPlay.UseVisualStyleBackColor = true;
            _ButtonPlay.Click += ButtonPlay_Click;
            // 
            // _ButtonBrowse
            // 
            _ButtonBrowse.Location = new Point(416, 153);
            _ButtonBrowse.Margin = new Padding(4, 3, 4, 3);
            _ButtonBrowse.Name = "_ButtonBrowse";
            _ButtonBrowse.Size = new Size(88, 27);
            _ButtonBrowse.TabIndex = 13;
            _ButtonBrowse.Text = "Browse";
            _ButtonBrowse.UseVisualStyleBackColor = true;
            _ButtonBrowse.Click += ButtonBrowse_Click;
            // 
            // _TextBoxSound
            // 
            _TextBoxSound.Location = new Point(7, 156);
            _TextBoxSound.Margin = new Padding(4, 3, 4, 3);
            _TextBoxSound.Name = "_TextBoxSound";
            _TextBoxSound.Size = new Size(368, 23);
            _TextBoxSound.TabIndex = 11;
            // 
            // _LabelSound
            // 
            _LabelSound.AutoSize = true;
            _LabelSound.Location = new Point(4, 137);
            _LabelSound.Margin = new Padding(4, 0, 4, 0);
            _LabelSound.Name = "_LabelSound";
            _LabelSound.Size = new Size(154, 15);
            _LabelSound.TabIndex = 15;
            _LabelSound.Text = "Sound File Name (Optional)";
            // 
            // _LabelClass
            // 
            _LabelClass.AutoSize = true;
            _LabelClass.Location = new Point(351, 90);
            _LabelClass.Margin = new Padding(4, 0, 4, 0);
            _LabelClass.Name = "_LabelClass";
            _LabelClass.Size = new Size(34, 15);
            _LabelClass.TabIndex = 13;
            _LabelClass.Text = "Class";
            // 
            // _ComboBoxClass
            // 
            _ComboBoxClass.FormattingEnabled = true;
            _ComboBoxClass.Location = new Point(355, 108);
            _ComboBoxClass.Margin = new Padding(4, 3, 4, 3);
            _ComboBoxClass.Name = "_ComboBoxClass";
            _ComboBoxClass.Size = new Size(149, 23);
            _ComboBoxClass.TabIndex = 10;
            _ComboBoxClass.Text = "(default)";
            // 
            // _CheckBoxAutoApply
            // 
            _CheckBoxAutoApply.AutoSize = true;
            _CheckBoxAutoApply.Location = new Point(102, 190);
            _CheckBoxAutoApply.Margin = new Padding(4, 3, 4, 3);
            _CheckBoxAutoApply.Name = "_CheckBoxAutoApply";
            _CheckBoxAutoApply.Size = new Size(128, 19);
            _CheckBoxAutoApply.TabIndex = 15;
            _CheckBoxAutoApply.Text = "Autoapply changes";
            _CheckBoxAutoApply.UseVisualStyleBackColor = true;
            _CheckBoxAutoApply.Visible = false;
            // 
            // _RadioButtonRegExp
            // 
            _RadioButtonRegExp.AutoSize = true;
            _RadioButtonRegExp.Location = new Point(233, 67);
            _RadioButtonRegExp.Margin = new Padding(4, 3, 4, 3);
            _RadioButtonRegExp.Name = "_RadioButtonRegExp";
            _RadioButtonRegExp.Size = new Size(64, 19);
            _RadioButtonRegExp.TabIndex = 4;
            _RadioButtonRegExp.Text = "RegExp";
            _RadioButtonRegExp.UseVisualStyleBackColor = true;
            _RadioButtonRegExp.CheckedChanged += TextBox_TextChanged;
            // 
            // _RadioButtonBeginsWith
            // 
            _RadioButtonBeginsWith.AutoSize = true;
            _RadioButtonBeginsWith.Location = new Point(134, 67);
            _RadioButtonBeginsWith.Margin = new Padding(4, 3, 4, 3);
            _RadioButtonBeginsWith.Name = "_RadioButtonBeginsWith";
            _RadioButtonBeginsWith.Size = new Size(85, 19);
            _RadioButtonBeginsWith.TabIndex = 3;
            _RadioButtonBeginsWith.Text = "BeginsWith";
            _RadioButtonBeginsWith.UseVisualStyleBackColor = true;
            _RadioButtonBeginsWith.CheckedChanged += TextBox_TextChanged;
            // 
            // _CheckBoxCaseSensitive
            // 
            _CheckBoxCaseSensitive.AutoSize = true;
            _CheckBoxCaseSensitive.Checked = true;
            _CheckBoxCaseSensitive.CheckState = CheckState.Checked;
            _CheckBoxCaseSensitive.Location = new Point(392, 67);
            _CheckBoxCaseSensitive.Margin = new Padding(4, 3, 4, 3);
            _CheckBoxCaseSensitive.Name = "_CheckBoxCaseSensitive";
            _CheckBoxCaseSensitive.Size = new Size(100, 19);
            _CheckBoxCaseSensitive.TabIndex = 6;
            _CheckBoxCaseSensitive.Text = "Case Sensitive";
            _CheckBoxCaseSensitive.UseVisualStyleBackColor = true;
            _CheckBoxCaseSensitive.CheckedChanged += TextBox_TextChanged;
            // 
            // _RadioButtonLine
            // 
            _RadioButtonLine.AutoSize = true;
            _RadioButtonLine.Location = new Point(75, 67);
            _RadioButtonLine.Margin = new Padding(4, 3, 4, 3);
            _RadioButtonLine.Name = "_RadioButtonLine";
            _RadioButtonLine.Size = new Size(47, 19);
            _RadioButtonLine.TabIndex = 2;
            _RadioButtonLine.Text = "Line";
            _RadioButtonLine.UseVisualStyleBackColor = true;
            _RadioButtonLine.CheckedChanged += TextBox_TextChanged;
            // 
            // _RadioButtonString
            // 
            _RadioButtonString.AutoSize = true;
            _RadioButtonString.Checked = true;
            _RadioButtonString.Location = new Point(7, 67);
            _RadioButtonString.Margin = new Padding(4, 3, 4, 3);
            _RadioButtonString.Name = "_RadioButtonString";
            _RadioButtonString.Size = new Size(56, 19);
            _RadioButtonString.TabIndex = 1;
            _RadioButtonString.TabStop = true;
            _RadioButtonString.Text = "String";
            _RadioButtonString.UseVisualStyleBackColor = true;
            _RadioButtonString.CheckedChanged += TextBox_TextChanged;
            // 
            // _ButtonColorBg
            // 
            _ButtonColorBg.Image = (Image)resources.GetObject("_ButtonColorBg.Image");
            _ButtonColorBg.Location = new Point(307, 107);
            _ButtonColorBg.Margin = new Padding(4, 3, 4, 3);
            _ButtonColorBg.Name = "_ButtonColorBg";
            _ButtonColorBg.Size = new Size(27, 27);
            _ButtonColorBg.TabIndex = 9;
            _ButtonColorBg.UseVisualStyleBackColor = true;
            _ButtonColorBg.Click += ButtonColorBg_Click;
            // 
            // _LabelExampleColor
            // 
            _LabelExampleColor.BackColor = Color.Black;
            _LabelExampleColor.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _LabelExampleColor.ForeColor = Color.Black;
            _LabelExampleColor.Location = new Point(191, 108);
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
            _ButtonColorFg.Location = new Point(273, 107);
            _ButtonColorFg.Margin = new Padding(4, 3, 4, 3);
            _ButtonColorFg.Name = "_ButtonColorFg";
            _ButtonColorFg.Size = new Size(27, 27);
            _ButtonColorFg.TabIndex = 8;
            _ButtonColorFg.UseVisualStyleBackColor = true;
            _ButtonColorFg.Click += ButtonColorFg_Click;
            // 
            // _LabelColor
            // 
            _LabelColor.AutoSize = true;
            _LabelColor.Location = new Point(4, 90);
            _LabelColor.Margin = new Padding(4, 0, 4, 0);
            _LabelColor.Name = "_LabelColor";
            _LabelColor.Size = new Size(36, 15);
            _LabelColor.TabIndex = 10;
            _LabelColor.Text = "Color";
            // 
            // _TextBoxHighlight
            // 
            _TextBoxHighlight.Location = new Point(7, 37);
            _TextBoxHighlight.Margin = new Padding(4, 3, 4, 3);
            _TextBoxHighlight.Name = "_TextBoxHighlight";
            _TextBoxHighlight.Size = new Size(496, 23);
            _TextBoxHighlight.TabIndex = 0;
            _TextBoxHighlight.TextChanged += TextBox_TextChanged;
            // 
            // _LabelHighlight
            // 
            _LabelHighlight.AutoSize = true;
            _LabelHighlight.Location = new Point(4, 18);
            _LabelHighlight.Margin = new Padding(4, 0, 4, 0);
            _LabelHighlight.Name = "_LabelHighlight";
            _LabelHighlight.Size = new Size(57, 15);
            _LabelHighlight.TabIndex = 8;
            _LabelHighlight.Text = "Highlight";
            // 
            // _ButtonApply
            // 
            _ButtonApply.Location = new Point(7, 186);
            _ButtonApply.Margin = new Padding(4, 3, 4, 3);
            _ButtonApply.Name = "_ButtonApply";
            _ButtonApply.Size = new Size(88, 27);
            _ButtonApply.TabIndex = 14;
            _ButtonApply.Text = "Apply";
            _ButtonApply.UseVisualStyleBackColor = true;
            _ButtonApply.Click += ButtonApply_Click;
            // 
            // _TextBoxColor
            // 
            _TextBoxColor.Location = new Point(7, 108);
            _TextBoxColor.Margin = new Padding(4, 3, 4, 3);
            _TextBoxColor.Name = "_TextBoxColor";
            _TextBoxColor.Size = new Size(177, 23);
            _TextBoxColor.TabIndex = 7;
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
            _ToolStripMenu.TabIndex = 2;
            // 
            // _ToolStripButtonRefresh
            // 
            _ToolStripButtonRefresh.ImageTransparentColor = Color.Magenta;
            _ToolStripButtonRefresh.Name = "_ToolStripButtonRefresh";
            _ToolStripButtonRefresh.Size = new Size(50, 22);
            _ToolStripButtonRefresh.Text = "Refresh";
            _ToolStripButtonRefresh.Click += ToolStripButtonRefresh_Click;
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
            // _OpenFileDialogSound
            // 
            _OpenFileDialogSound.DefaultExt = "wav";
            _OpenFileDialogSound.Filter = "Sounds|*.wav|All files|*.*";
            _OpenFileDialogSound.RestoreDirectory = true;
            _OpenFileDialogSound.Title = "Select Sound File";
            // 
            // UCHighlightStrings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_ListViewBase);
            Controls.Add(_GroupBoxBase);
            Controls.Add(_ToolStripMenu);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UCHighlightStrings";
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

        private TextBox _TextBoxHighlight;

        internal TextBox TextBoxHighlight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxHighlight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxHighlight != null)
                {
                    _TextBoxHighlight.TextChanged -= TextBox_TextChanged;
                }

                _TextBoxHighlight = value;
                if (_TextBoxHighlight != null)
                {
                    _TextBoxHighlight.TextChanged += TextBox_TextChanged;
                }
            }
        }

        private Label _LabelHighlight;

        internal Label LabelHighlight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelHighlight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelHighlight != null)
                {
                }

                _LabelHighlight = value;
                if (_LabelHighlight != null)
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
                    _ToolStripButtonRefresh.Click -= ToolStripButtonRefresh_Click;
                }

                _ToolStripButtonRefresh = value;
                if (_ToolStripButtonRefresh != null)
                {
                    _ToolStripButtonRefresh.Click += ToolStripButtonRefresh_Click;
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

        private RadioButton _RadioButtonLine;

        internal RadioButton RadioButtonLine
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RadioButtonLine;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RadioButtonLine != null)
                {
                    _RadioButtonLine.CheckedChanged -= TextBox_TextChanged;
                }

                _RadioButtonLine = value;
                if (_RadioButtonLine != null)
                {
                    _RadioButtonLine.CheckedChanged += TextBox_TextChanged;
                }
            }
        }

        private RadioButton _RadioButtonString;

        internal RadioButton RadioButtonString
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RadioButtonString;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RadioButtonString != null)
                {
                    _RadioButtonString.CheckedChanged -= TextBox_TextChanged;
                }

                _RadioButtonString = value;
                if (_RadioButtonString != null)
                {
                    _RadioButtonString.CheckedChanged += TextBox_TextChanged;
                }
            }
        }

        private RadioButton _RadioButtonRegExp;

        internal RadioButton RadioButtonRegExp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RadioButtonRegExp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RadioButtonRegExp != null)
                {
                    _RadioButtonRegExp.CheckedChanged -= TextBox_TextChanged;
                }

                _RadioButtonRegExp = value;
                if (_RadioButtonRegExp != null)
                {
                    _RadioButtonRegExp.CheckedChanged += TextBox_TextChanged;
                }
            }
        }

        private RadioButton _RadioButtonBeginsWith;

        internal RadioButton RadioButtonBeginsWith
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RadioButtonBeginsWith;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RadioButtonBeginsWith != null)
                {
                    _RadioButtonBeginsWith.CheckedChanged -= TextBox_TextChanged;
                }

                _RadioButtonBeginsWith = value;
                if (_RadioButtonBeginsWith != null)
                {
                    _RadioButtonBeginsWith.CheckedChanged += TextBox_TextChanged;
                }
            }
        }

        private CheckBox _CheckBoxCaseSensitive;

        internal CheckBox CheckBoxCaseSensitive
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxCaseSensitive;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxCaseSensitive != null)
                {
                    _CheckBoxCaseSensitive.CheckedChanged -= TextBox_TextChanged;
                }

                _CheckBoxCaseSensitive = value;
                if (_CheckBoxCaseSensitive != null)
                {
                    _CheckBoxCaseSensitive.CheckedChanged += TextBox_TextChanged;
                }
            }
        }

        private CheckBox _CheckBoxAutoApply;

        internal CheckBox CheckBoxAutoApply
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxAutoApply;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxAutoApply != null)
                {
                }

                _CheckBoxAutoApply = value;
                if (_CheckBoxAutoApply != null)
                {
                }
            }
        }

        private Label _LabelClass;

        internal Label LabelClass
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelClass;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelClass != null)
                {
                }

                _LabelClass = value;
                if (_LabelClass != null)
                {
                }
            }
        }

        private ComboBox _ComboBoxClass;

        internal ComboBox ComboBoxClass
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxClass;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxClass != null)
                {
                }

                _ComboBoxClass = value;
                if (_ComboBoxClass != null)
                {
                }
            }
        }

        private TextBox _TextBoxSound;

        internal TextBox TextBoxSound
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxSound;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxSound != null)
                {
                }

                _TextBoxSound = value;
                if (_TextBoxSound != null)
                {
                }
            }
        }

        private Label _LabelSound;

        internal Label LabelSound
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelSound;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelSound != null)
                {
                }

                _LabelSound = value;
                if (_LabelSound != null)
                {
                }
            }
        }

        private Button _ButtonBrowse;

        internal Button ButtonBrowse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonBrowse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonBrowse != null)
                {
                    _ButtonBrowse.Click -= ButtonBrowse_Click;
                }

                _ButtonBrowse = value;
                if (_ButtonBrowse != null)
                {
                    _ButtonBrowse.Click += ButtonBrowse_Click;
                }
            }
        }

        private Button _ButtonPlay;

        internal Button ButtonPlay
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonPlay;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonPlay != null)
                {
                    _ButtonPlay.Click -= ButtonPlay_Click;
                }

                _ButtonPlay = value;
                if (_ButtonPlay != null)
                {
                    _ButtonPlay.Click += ButtonPlay_Click;
                }
            }
        }

        private OpenFileDialog _OpenFileDialogSound;

        internal OpenFileDialog OpenFileDialogSound
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OpenFileDialogSound;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OpenFileDialogSound != null)
                {
                }

                _OpenFileDialogSound = value;
                if (_OpenFileDialogSound != null)
                {
                }
            }
        }
    }
}