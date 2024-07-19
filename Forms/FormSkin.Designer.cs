using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GenieClient
{
    [DesignerGenerated()]
    public partial class FormSkin : Form
    {

        // Form overrides dispose to clean up the component list.
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
            _PanelContents = new Panel();
            _RichTextBoxOutput = new ComponentRichTextBox();
            _ContextMenuStripOutput = new ContextMenuStrip(components);
            _ClearToolStripMenuItem = new ToolStripMenuItem();
            _TimeStampToolStripMenuItem = new ToolStripMenuItem();
            _NameListOnlyToolStripMenuItem = new ToolStripMenuItem();
            _HideShowScrollbarToolStripMenuItem = new ToolStripMenuItem(); // hide/show scrollbar
            _HideShowTitleBarToolStripMenuItem = new ToolStripMenuItem(); // hide/show titlebar
            _ToolStripSeparator1 = new ToolStripSeparator();
            _CloseWindowToolStripMenuItem = new ToolStripMenuItem();
            _PanelContents.SuspendLayout();
            _ContextMenuStripOutput.SuspendLayout();
            SuspendLayout();
            // 
            // _PanelContents
            // 
            _PanelContents.BackColor = Color.Black;
            _PanelContents.Controls.Add(_RichTextBoxOutput);
            _PanelContents.Dock = DockStyle.Fill;
            _PanelContents.Location = new Point(0, 0);
            _PanelContents.Margin = new Padding(4);
            _PanelContents.Name = "_PanelContents";
            _PanelContents.Size = new Size(350, 231);
            _PanelContents.TabIndex = 2;
            _PanelContents.Visible = false;
            _PanelContents.MouseEnter += PanelContents_MouseEnter;
            // 
            // _RichTextBoxOutput
            // 
            _RichTextBoxOutput.BackColor = Color.Black;
            _RichTextBoxOutput.BorderStyle = BorderStyle.None;
            _RichTextBoxOutput.ContextMenuStrip = _ContextMenuStripOutput;
            _RichTextBoxOutput.DetectUrls = false;
            _RichTextBoxOutput.Dock = DockStyle.Fill;
            _RichTextBoxOutput.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _RichTextBoxOutput.ForeColor = Color.WhiteSmoke;
            _RichTextBoxOutput.FormParent = null;
            _RichTextBoxOutput.HideSelection = false;
            _RichTextBoxOutput.HideShowScrollbar = false; // hide/show scrollbar
            _RichTextBoxOutput.HideShowTitleBar = false; // hide/show titlebar
            _RichTextBoxOutput.IsMainWindow = false;
            _RichTextBoxOutput.Location = new Point(0, 0);
            _RichTextBoxOutput.Margin = new Padding(4);
            _RichTextBoxOutput.MaxBufferSize = 500000;
            _RichTextBoxOutput.MonoFont = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _RichTextBoxOutput.Name = "_RichTextBoxOutput";
            _RichTextBoxOutput.NameListOnly = false;
            _RichTextBoxOutput.ReadOnly = true;
            _RichTextBoxOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            _RichTextBoxOutput.ShowSelectionMargin = true;
            _RichTextBoxOutput.Size = new Size(350, 231);
            _RichTextBoxOutput.TabIndex = 7;
            _RichTextBoxOutput.Text = "";
            _RichTextBoxOutput.TimeStamp = false;
            _RichTextBoxOutput.Visible = false;
            _RichTextBoxOutput.EventKeyDown += MyKeyDown;
            _RichTextBoxOutput.EventKeyPress += MyKeyPress;
            _RichTextBoxOutput.LinkClicked += RichTextBoxOutput_LinkClicked;
            _RichTextBoxOutput.KeyDown += _RichTextBoxOutput_KeyDown;
            _RichTextBoxOutput.KeyPress += _RichTextBoxOutput_KeyPress;
            _RichTextBoxOutput.MouseDown += _RichTextBoxOutput_MouseDown;
            _RichTextBoxOutput.MouseUp += _RichTextBoxOutput_MouseUp;
            _RichTextBoxOutput.MouseWheel += _RichTextBoxOutput_MouseWheel;
            // 
            // _ContextMenuStripOutput
            // 
            _ContextMenuStripOutput.ImageScalingSize = new Size(24, 24);
            _ContextMenuStripOutput.Items.AddRange(new ToolStripItem[] { _ClearToolStripMenuItem, _TimeStampToolStripMenuItem, _NameListOnlyToolStripMenuItem, _HideShowScrollbarToolStripMenuItem, _HideShowTitleBarToolStripMenuItem, _ToolStripSeparator1, _CloseWindowToolStripMenuItem }); // hide/show scroll bar hide/show titlebar
            _ContextMenuStripOutput.Name = "ContextMenuStripOutput";
            _ContextMenuStripOutput.Size = new Size(181, 164);
            // 
            // _ClearToolStripMenuItem
            // 
            _ClearToolStripMenuItem.Name = "_ClearToolStripMenuItem";
            _ClearToolStripMenuItem.Size = new Size(180, 22);
            _ClearToolStripMenuItem.Text = "Clear";
            _ClearToolStripMenuItem.Click += ClearToolStripMenuItem_Click;
            // 
            // _TimeStampToolStripMenuItem
            // 
            _TimeStampToolStripMenuItem.Name = "_TimeStampToolStripMenuItem";
            _TimeStampToolStripMenuItem.Size = new Size(180, 22);
            _TimeStampToolStripMenuItem.Text = "Time Stamp";
            _TimeStampToolStripMenuItem.Click += TimeStampToolStripMenuItem_Click;
            // 
            // _NameListOnlyToolStripMenuItem
            // 
            _NameListOnlyToolStripMenuItem.Name = "_NameListOnlyToolStripMenuItem";
            _NameListOnlyToolStripMenuItem.Size = new Size(180, 22);
            _NameListOnlyToolStripMenuItem.Text = "Name List Only";
            _NameListOnlyToolStripMenuItem.Click += NameListOnlyToolStripMenuItem_Click;
            // 
            // _HideShowScrollbarToolStripMenuItem
            // 
            _HideShowScrollbarToolStripMenuItem.Name = "_HideShowScrollbarToolStripMenuItem";
            _HideShowScrollbarToolStripMenuItem.Size = new Size(180, 22);
            _HideShowScrollbarToolStripMenuItem.Text = "Show Scrollbar";
            _HideShowScrollbarToolStripMenuItem.Click += HideShowScrollbarToolStripMenuItem_Click;
            // 
            // _HideShowTitleBarToolStripMenuItem
            // 
            _HideShowTitleBarToolStripMenuItem.Name = "_HideShowTitleBarToolStripMenuItem";
            _HideShowTitleBarToolStripMenuItem.Size = new Size(180, 22);
            _HideShowTitleBarToolStripMenuItem.Text = "Hide Titlebar";
            _HideShowTitleBarToolStripMenuItem.Click += HideShowTitleBarToolStripMenuItem_Click;
            // 
            // _ToolStripSeparator1
            // 
            _ToolStripSeparator1.Name = "_ToolStripSeparator1";
            _ToolStripSeparator1.Size = new Size(177, 6);
            // 
            // _CloseWindowToolStripMenuItem
            // 
            _CloseWindowToolStripMenuItem.Name = "_CloseWindowToolStripMenuItem";
            _CloseWindowToolStripMenuItem.Size = new Size(180, 22);
            _CloseWindowToolStripMenuItem.Text = "Close Window";
            _CloseWindowToolStripMenuItem.Click += CloseWindowToolStripMenuItem_Click;
            // 
            // FormSkin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(350, 231);
            Controls.Add(_PanelContents);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimumSize = new Size(58, 58);
            Name = "FormSkin";
            StartPosition = FormStartPosition.Manual;
            Load += FormSkin_Load;
            Shown += FormSkin_Shown;
            VisibleChanged += FormSkin_VisibleChanged;
            Paint += FormSkin_Paint;
            DoubleClick += FormSkin_DoubleClick;
            Enter += FormSkin_Enter;
            GotFocus += FormSkin_GotFocus;
            MouseDown += FormSkin_MouseDown;
            MouseMove += FormSkin_MouseMove;
            Resize += FormSkin_Resize;
            _PanelContents.ResumeLayout(false);
            _ContextMenuStripOutput.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void FormSkin_GotFocus(object sender, EventArgs e)
        {
            this._RichTextBoxOutput.ComponentRichTextBox_GotFocus(sender, e);
        }

        private Panel _PanelContents;

        private Panel PanelContents
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PanelContents;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PanelContents != null)
                {
                    _PanelContents.MouseEnter -= PanelContents_MouseEnter;
                }

                _PanelContents = value;
                if (_PanelContents != null)
                {
                    _PanelContents.MouseEnter += PanelContents_MouseEnter;
                }
            }
        }

        private ComponentRichTextBox _RichTextBoxOutput;

        internal ComponentRichTextBox RichTextBoxOutput
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RichTextBoxOutput;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RichTextBoxOutput != null)
                {
                    _RichTextBoxOutput.EventKeyDown -= MyKeyDown;
                    _RichTextBoxOutput.EventKeyPress -= MyKeyPress;
                    _RichTextBoxOutput.LinkClicked -= RichTextBoxOutput_LinkClicked;
                }

                _RichTextBoxOutput = value;
                if (_RichTextBoxOutput != null)
                {
                    _RichTextBoxOutput.EventKeyDown += MyKeyDown;
                    _RichTextBoxOutput.EventKeyPress += MyKeyPress;
                    _RichTextBoxOutput.LinkClicked += RichTextBoxOutput_LinkClicked;
                }
            }
        }

        private ContextMenuStrip _ContextMenuStripOutput;

        internal ContextMenuStrip ContextMenuStripOutput
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ContextMenuStripOutput;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ContextMenuStripOutput != null)
                {
                }

                _ContextMenuStripOutput = value;
                if (_ContextMenuStripOutput != null)
                {
                }
            }
        }

        private ToolStripMenuItem _ClearToolStripMenuItem;

        internal ToolStripMenuItem ClearToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ClearToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ClearToolStripMenuItem != null)
                {
                    _ClearToolStripMenuItem.Click -= ClearToolStripMenuItem_Click;
                }

                _ClearToolStripMenuItem = value;
                if (_ClearToolStripMenuItem != null)
                {
                    _ClearToolStripMenuItem.Click += ClearToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _TimeStampToolStripMenuItem;

        internal ToolStripMenuItem TimeStampToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TimeStampToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TimeStampToolStripMenuItem != null)
                {
                    _TimeStampToolStripMenuItem.Click -= TimeStampToolStripMenuItem_Click;
                }

                _TimeStampToolStripMenuItem = value;
                if (_TimeStampToolStripMenuItem != null)
                {
                    _TimeStampToolStripMenuItem.Click += TimeStampToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _NameListOnlyToolStripMenuItem;

        internal ToolStripMenuItem NameListOnlyToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NameListOnlyToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NameListOnlyToolStripMenuItem != null)
                {
                    _NameListOnlyToolStripMenuItem.Click -= NameListOnlyToolStripMenuItem_Click;
                }

                _NameListOnlyToolStripMenuItem = value;
                if (_NameListOnlyToolStripMenuItem != null)
                {
                    _NameListOnlyToolStripMenuItem.Click += NameListOnlyToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _HideShowScrollbarToolStripMenuItem; // Hide/Show scrollbar

        internal ToolStripMenuItem HideShowScrollbarToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HideShowScrollbarToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_HideShowScrollbarToolStripMenuItem != null)
                {
                    _HideShowScrollbarToolStripMenuItem.Click -= HideShowScrollbarToolStripMenuItem_Click;
                }

                _HideShowScrollbarToolStripMenuItem = value;
                if (_HideShowScrollbarToolStripMenuItem != null)
                {
                    _HideShowScrollbarToolStripMenuItem.Click += HideShowScrollbarToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _HideShowTitleBarToolStripMenuItem; // Hide/Show titlebar

        internal ToolStripMenuItem HideShowTitleBarToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HideShowTitleBarToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_HideShowTitleBarToolStripMenuItem != null)
                {
                    _HideShowTitleBarToolStripMenuItem.Click -= HideShowTitleBarToolStripMenuItem_Click;
                }

                _HideShowTitleBarToolStripMenuItem = value;
                if (_HideShowTitleBarToolStripMenuItem != null)
                {
                    _HideShowTitleBarToolStripMenuItem.Click += HideShowTitleBarToolStripMenuItem_Click;
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

        private ToolStripMenuItem _CloseWindowToolStripMenuItem;

        internal ToolStripMenuItem CloseWindowToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CloseWindowToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CloseWindowToolStripMenuItem != null)
                {
                    _CloseWindowToolStripMenuItem.Click -= CloseWindowToolStripMenuItem_Click;
                }

                _CloseWindowToolStripMenuItem = value;
                if (_CloseWindowToolStripMenuItem != null)
                {
                    _CloseWindowToolStripMenuItem.Click += CloseWindowToolStripMenuItem_Click;
                }
            }
        }
    }
}