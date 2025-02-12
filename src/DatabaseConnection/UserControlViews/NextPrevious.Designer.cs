using System.ComponentModel;

namespace UserControlViews;

partial class NextPrevious
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
        next = new System.Windows.Forms.Button();
        back = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // next
        // 
        next.Location = new System.Drawing.Point(639, 370);
        next.Name = "next";
        next.Size = new System.Drawing.Size(127, 72);
        next.TabIndex = 0;
        next.Text = "next";
        next.UseVisualStyleBackColor = true;
        // 
        // back
        // 
        back.Location = new System.Drawing.Point(101, 370);
        back.Name = "back";
        back.Size = new System.Drawing.Size(127, 72);
        back.TabIndex = 1;
        back.Text = "back";
        back.UseVisualStyleBackColor = true;
        // 
        // NextPrevious
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(back);
        Controls.Add(next);
        Size = new System.Drawing.Size(915, 565);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button next;
    private System.Windows.Forms.Button back;

    #endregion
}