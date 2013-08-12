/**
* @file  MainWindow.cs
* @brief Source implementing the main MDI window of the application.
*
*
* @section License
*
* Copyright (C) 2013 Robert B. Colton
* This file is a part of the LateralGM IDE.
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program. If not, see <http://www.gnu.org/licenses/>.
**/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LateralGM.Editors;
using LateralGM.Dialogues;

namespace LateralGM
{
    public partial class MainWindow : Form
    {
        private int childFormNumber = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            ScriptEditor childForm = new ScriptEditor();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void newSpriteBt_Click(object sender, EventArgs e)
        {
            SpriteEditor childForm = new SpriteEditor();
            childForm.MdiParent = this;
            childForm.Text = "Sprite";
            childForm.Show();
        }

        private void newSoundBt_Click(object sender, EventArgs e)
        {
            SoundEditor childForm = new SoundEditor();
            childForm.MdiParent = this;
            childForm.Text = "Sound";
            childForm.Show();
        }

        private void newBackgroundBt_Click(object sender, EventArgs e)
        {
            BackgroundEditor childForm = new BackgroundEditor();
            childForm.MdiParent = this;
            childForm.Text = "Background";
            childForm.Show();
        }

        private void newPathBt_Click(object sender, EventArgs e)
        {
            PathEditor childForm = new PathEditor();
            childForm.MdiParent = this;
            childForm.Text = "Path";
            childForm.Show();
        }

        private void newScriptBt_Click(object sender, EventArgs e)
        {
            ScriptEditor childForm = new ScriptEditor();
            childForm.MdiParent = this;
            childForm.Text = "Script";
            childForm.Show();
        }

        private void newShaderBt_Click(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Shader";
            childForm.Show();
        }

        private void newFontBt_Click(object sender, EventArgs e)
        {
            FontEditor childForm = new FontEditor();
            childForm.MdiParent = this;
            childForm.Text = "Font";
            childForm.Show();
        }

        private void newTimelineBt_Click(object sender, EventArgs e)
        {
            TimelineEditor childForm = new TimelineEditor();
            childForm.MdiParent = this;
            childForm.Text = "Timeline";
            childForm.Show();
        }

        private void newObjectBt_Click(object sender, EventArgs e)
        {
            ObjectEditor childForm = new ObjectEditor();
            childForm.MdiParent = this;
            childForm.Text = "Object";
            childForm.Show();
        }

        private void newRoomBt_Click(object sender, EventArgs e)
        {
            RoomEditor childForm = new RoomEditor();
            childForm.MdiParent = this;
            childForm.Text = "Room";
            childForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpViewer helpViewer = new HelpViewer();
            helpViewer.Show();
        }
    }
}
