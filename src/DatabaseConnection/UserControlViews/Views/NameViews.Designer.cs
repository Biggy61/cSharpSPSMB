using System.ComponentModel;

namespace UserControlViews.Views;

partial class NameViews
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        back = new System.Windows.Forms.Button();
        next = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(327, 23);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(184, 65);
        label1.TabIndex = 0;
        label1.Text = "Name";
        // 
        // back
        // 
        back.Location = new System.Drawing.Point(0, 487);
        back.Name = "back";
        back.Size = new System.Drawing.Size(125, 62);
        back.TabIndex = 1;
        back.Text = "back";
        back.UseVisualStyleBackColor = true;
        back.Click += back_Click;
        // 
        // next
        // 
        next.Location = new System.Drawing.Point(829, 487);
        next.Name = "next";
        next.Size = new System.Drawing.Size(125, 62);
        next.TabIndex = 2;
        next.Text = "next";
        next.UseVisualStyleBackColor = true;
        next.Click += next_Click;
        // 
        // NameViews
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(next);
        Controls.Add(back);
        Controls.Add(label1);
        Size = new System.Drawing.Size(957, 549);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button back;
    private System.Windows.Forms.Button next;

    private System.Windows.Forms.Label label1;

    #endregion
}