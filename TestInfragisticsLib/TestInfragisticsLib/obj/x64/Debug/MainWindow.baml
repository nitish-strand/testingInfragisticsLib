   M S B A M L   `   `   `  ����F  BDataChart3D, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullN6clr-namespace:Infragistics.Common;assembly=DataChart3DInfragistics.Common  5   	   `?clr-namespace:Infragistics.Controls.Charts;assembly=DataChart3DInfragistics.Controls.Charts  5   	   N JTestInfragisticsLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TestInfragisticsLibTestInfragisticsLib 5   	   $   TestInfragisticsLib.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Icommon6clr-namespace:Infragistics.Common;assembly=DataChart3D     5   	   Rcharts?clr-namespace:Infragistics.Controls.Charts;assembly=DataChart3D     5   	   3local!clr-namespace:TestInfragisticsLib     5   	   $	��450��5
   !   $	��800��6.     � Title  6	   �� *Title+ � DataContext 5      #  TestInfragisticsLib.ViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6    � 	Resources 5   
   ��%    5      .+�5   
   �� $��0��6    5       �� 
TargetType �� Property �� Value��%|   '��       �� 5!      " ��6   .�5"      ��  � ��$ 6(�61   �� 5#       �@��Padding$ 2q�60   5$      5%      ._�5&      *   $Infragistics.Controls.Charts.Heatmap  -   5          Name$ Heatmap��5&      	   ValueMemberPath$	 PropertyTwo��5(   !   
   ColumnFormat$
 {0:dd/MM/yy}��5*   @      DisplayMode$
 None=�5+   !      	TextWidth$	 150Q�5,   !   $��10q�5-   !      ItemsSource 5'   !   �� *Data+   
RowsSource 5)   !   �� *Rows+   ColumnsSource 5*   !   �� *Cols+   
ValueScale 5/      %   Infragistics.Common.LinearScale  50         MinimumValue$ 0Q�6)      MaximumValue$	 100Q�6:      Infragistics.Common.Scale   ColorsB   <Infragistics.Common.ColorCollection+ColorCollectionConverter$ #d7191c #ffffbf #1a9641 6M   54      56      �� 57   
   $��1��6   .+�58      �� $��Just Something��6   59      �� 5:   
   $��2��6   .+�5;      �� $��Just Something��6   5<      �� 5=   
   $��1��6   .+�5>      �� $��Just SomeFooter��6   5?      5A      5C      