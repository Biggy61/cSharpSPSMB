using System.ComponentModel;

namespace UserControlViews.Views;

partial class NavigationView
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
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        back = new System.Windows.Forms.Button();
        next = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        label1.Location = new System.Drawing.Point(0, 74);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(816, 47);
        label1.TabIndex = 0;
        label1.Text = "Navigation";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(352, 175);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(123, 44);
        button1.TabIndex = 1;
        button1.Text = "Standa View";
        button1.UseVisualStyleBackColor = true;
        button1.Click += StandaViewButton_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(352, 248);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(123, 44);
        button2.TabIndex = 1;
        button2.Text = "Zdarsky View";
        button2.UseVisualStyleBackColor = true;
        button2.Click += ZdarskyViewButton_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(352, 319);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(123, 44);
        button3.TabIndex = 2;
        button3.Text = "Bohata View";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // back
        // 
        back.Location = new System.Drawing.Point(0, 442);
        back.Name = "back";
        back.Size = new System.Drawing.Size(123, 44);
        back.TabIndex = 3;
        back.Text = "back";
        back.UseVisualStyleBackColor = true;
        back.Click += back_Click;
        // 
        // next
        // 
        next.Location = new System.Drawing.Point(693, 445);
        next.Name = "next";
        next.Size = new System.Drawing.Size(123, 44);
        next.TabIndex = 4;
        next.Text = "next";
        next.UseVisualStyleBackColor = true;
        next.Click += next_Click;
        // 
        // NavigationView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(next);
        Controls.Add(back);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label1);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(816, 489);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button back;
    private System.Windows.Forms.Button next;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;

    #endregion
}