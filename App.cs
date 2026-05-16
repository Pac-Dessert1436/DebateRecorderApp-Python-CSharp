// Copyright 2026 Pac-Dessert1436
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#:property PublishTrimmed=false
#:property TargetFramework=net10.0-windows
#:property UseWindowsForms=true
#:property PublishSingleFile=true

file sealed class App : Form
{
    private TextBox? _txtProTeamName;
    private TextBox? _txtProPosition;
    private NumericUpDown? _numProScore;
    private TextBox? _txtProRecords;
    private TextBox? _txtConTeamName;
    private TextBox? _txtConPosition;
    private NumericUpDown? _numConScore;
    private TextBox? _txtConRecords;

    public App()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        Text = "C# Winforms辩论记录应用-单文件版";
        Size = new System.Drawing.Size(800, 600);
        MinimumSize = new System.Drawing.Size(600, 400);

        var lblPro = new Label { Text = "正方：", AutoSize = true };
        _txtProTeamName = new TextBox { Text = "填入队伍名称", Width = 120 };
        var lblProPosition = new Label { Text = "观点：", AutoSize = true };
        _txtProPosition = new TextBox { Text = "填入所持观点", Width = 200 };
        var lblProScore = new Label { Text = "当前得分：", AutoSize = true };
        _numProScore = new NumericUpDown { Minimum = 0, Maximum = 10, Value = 0, Width = 80 };

        _txtProRecords = new TextBox
        {
            Dock = DockStyle.Fill,
            Multiline = true,
            ScrollBars = ScrollBars.Vertical
        };

        var lblCon = new Label { Text = "反方：", AutoSize = true };
        _txtConTeamName = new TextBox { Text = "填入队伍名称", Width = 120 };
        var lblConPosition = new Label { Text = "观点：", AutoSize = true };
        _txtConPosition = new TextBox { Text = "填入所持观点", Width = 200 };
        var lblConScore = new Label { Text = "当前得分：", AutoSize = true };
        _numConScore = new NumericUpDown { Minimum = 0, Maximum = 10, Value = 0, Width = 80 };

        _txtConRecords = new TextBox
        {
            Dock = DockStyle.Fill,
            Multiline = true,
            ScrollBars = ScrollBars.Vertical
        };

        var proHeaderPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            Padding = new Padding(5),
            BackColor = System.Drawing.Color.LightBlue
        };
        proHeaderPanel.Controls.Add(lblPro);
        proHeaderPanel.Controls.Add(_txtProTeamName);
        proHeaderPanel.Controls.Add(lblProPosition);
        proHeaderPanel.Controls.Add(_txtProPosition);
        proHeaderPanel.Controls.Add(lblProScore);
        proHeaderPanel.Controls.Add(_numProScore);

        var proPanel = new Panel { Dock = DockStyle.Fill };
        proPanel.Controls.Add(proHeaderPanel);
        proPanel.Controls.Add(_txtProRecords);
        _txtProRecords.BringToFront();

        var conHeaderPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            Padding = new Padding(5),
            BackColor = System.Drawing.Color.LightPink
        };
        conHeaderPanel.Controls.Add(lblCon);
        conHeaderPanel.Controls.Add(_txtConTeamName);
        conHeaderPanel.Controls.Add(lblConPosition);
        conHeaderPanel.Controls.Add(_txtConPosition);
        conHeaderPanel.Controls.Add(lblConScore);
        conHeaderPanel.Controls.Add(_numConScore);

        var conPanel = new Panel { Dock = DockStyle.Fill };
        conPanel.Controls.Add(conHeaderPanel);
        conPanel.Controls.Add(_txtConRecords);
        _txtConRecords.BringToFront();

        var splitContainer = new SplitContainer
        {
            Dock = DockStyle.Fill,
            Orientation = Orientation.Horizontal
        };
        splitContainer.Panel1.Controls.Add(proPanel);
        splitContainer.Panel2.Controls.Add(conPanel);

        Controls.Add(splitContainer);
    }

    internal static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new App());
    }
}