using System.ComponentModel;

namespace UserControlViews.Views;

partial class BohataView
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
        button1 = new System.Windows.Forms.Button();
        Next = new System.Windows.Forms.Button();
        back = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label1.Location = new System.Drawing.Point(0, 93);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(815, 49);
        label1.TabIndex = 0;
        label1.Text = "Bohata View";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(352, 178);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(122, 37);
        button1.TabIndex = 1;
        button1.Text = "Back";
        button1.UseVisualStyleBackColor = true;
        button1.Click += BackButton_Click;
        // 
        // Next
        // 
        Next.Location = new System.Drawing.Point(686, 421);
        Next.Name = "Next";
        Next.Size = new System.Drawing.Size(130, 68);
        Next.TabIndex = 2;
        Next.Text = "Next";
        Next.UseVisualStyleBackColor = true;
        Next.Click += Next_Click;
        // 
        // back
        // 
        back.Location = new System.Drawing.Point(3, 421);
        back.Name = "back";
        back.Size = new System.Drawing.Size(123, 68);
        back.TabIndex = 3;
        back.Text = "Back";
        back.UseVisualStyleBackColor = true;
        back.Click += back_Click;
        // 
        // BohataView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(back);
        Controls.Add(Next);
        Controls.Add(button1);
        Controls.Add(label1);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(816, 489);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button Next;
    private System.Windows.Forms.Button back;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;

    #endregion
}