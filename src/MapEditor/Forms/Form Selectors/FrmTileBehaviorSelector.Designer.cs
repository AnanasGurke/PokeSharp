﻿namespace MapEditor.Forms.Form_Selectors {
	partial class FrmTileBehaviorSelector {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.control = new MapEditor.Data.Controls.EditorView.ControlTileBehaviorSelector();
			this.SuspendLayout();
			// 
			// control
			// 
			this.control.Dock = System.Windows.Forms.DockStyle.Fill;
			this.control.GameLoopEnabled = true;
			this.control.Location = new System.Drawing.Point(0, 0);
			this.control.Name = "control";
			this.control.Size = new System.Drawing.Size(235, 392);
			this.control.TabIndex = 0;
			this.control.Text = "control";
			this.control.TimeStep = 16.66666F;
			// 
			// FrmTileBehaviorSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 392);
			this.Controls.Add(this.control);
			this.Name = "FrmTileBehaviorSelector";
			this.Text = "FrmTileBehaviorSelector";
			this.ResumeLayout(false);

		}

		#endregion

		private Data.Controls.EditorView.ControlTileBehaviorSelector control;
	}
}