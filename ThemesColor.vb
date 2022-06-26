Module ThemesColor
    Public Property PrimaryColor As Color
    Public Property SecondaryColor As Color
    Public ColorList As List(Of String) = New List(Of String)() From {
        "#3F51B5",
        "#009688",
        "#FF5722",
        "#607D8B",
        "#FF9800",
        "#9C27B0",
        "#2196F3",
        "#EA676C",
        "#E41A4A",
        "#5978BB",
        "#018790",
        "#0E3441",
        "#00B0AD",
        "#721D47",
        "#EA4833",
        "#EF937E",
        "#F37521",
        "#A12059",
        "#126881",
        "#8BC240",
        "#364D5B",
        "#C7DC5B",
        "#0094BC",
        "#E4126B",
        "#43B76E",
        "#7BCFE9",
        "#B71C46"
    }
    Function ChangeColorBrightness(color As Color, correctionFactor As Double) As Color
        Dim red As Double = color.R
        Dim green As Double = color.G
        Dim blue As Double = color.B
        'If correction factor is less than 0, darken color.'
        If correctionFactor < 0 Then
            correctionFactor = 1 + correctionFactor
            red *= correctionFactor
            green *= correctionFactor
            blue *= correctionFactor
            'If correction factor is greater than zero, lighten color.'
        Else
            red = (255 - red) * correctionFactor + red
            green = (255 - green) * correctionFactor + green
            blue = (255 - blue) * correctionFactor + blue
        End If
        Return Color.FromArgb(color.A, CByte(red), CByte(green), CByte(blue))
    End Function
End Module
