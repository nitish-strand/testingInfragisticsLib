   M S B A M L   `   `   `  ����F  BDataChart3D, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullN6clr-namespace:Infragistics.Common;assembly=DataChart3DInfragistics.Common  5   	   `?clr-namespace:Infragistics.Controls.Charts;assembly=DataChart3DInfragistics.Controls.Charts  5   	    
HeatmapApp   HeatmapApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Icommon6clr-namespace:Infragistics.Common;assembly=DataChart3D     5   	   Rcharts?clr-namespace:Infragistics.Controls.Charts;assembly=DataChart3D     5   	     � Title$"  Infragistics Heatmap Control��5   	   $	��600��6.   $	��800��6;    � 	Resources 5         ItemToolTipTemplate  TooltipBackgroundBrush  TooltipBorderBrush �� Padding  TextBlockStyle �� BasedOn �� 
TargetType �� Property �� Value � RowDefinitions � ColumnDefinitions  TitleForegroundBrush	 �� Path  LighterForegroundBrush
 �� StringFormat��%G  &	        7  7  7  7  7  �� 5
   
   .R�5      �� 8��  8�� $��1q�6|   $ 8,0,8,4q�6�   ._�5      �  5      ���� 5      8  '��       " ��6D   .�5      ��  � ��$ 13.333(�60   5   	   5       5      �� 5      $
��auto �6(   �� 5      $
��auto �6(   �� 5      $
��auto �6(    5      �� 5      $
��auto �6+   �� 5      $
��auto �6+   .+�5      �� $��2��6    $��37.333(�61   $��Calibri)�6C   $��$��6X   $��0,0,8,0q�6a   8�� $��Center=�6�   �� 5      $��0��6    $��1��6-   $��Bottom=�6_   ��6=   �� $	 Ticker.Name�6_   �� 5      $��1��6    $��1��6-   8�� ��6=   �� $	 PropertyTwo�$
 {0:#.00}��6x   �� 5      $��2��6    $��1��6-   ��6=   �� $
	 Date�$
 {0:dd/MM/yy}��5      5       5!      5"      .��5$      �   ApplicationBackgroundBrush#��[ 6    5%   
   �� 5&      $��* �6   �� 5'      $
��auto �6   �� 5(      $
��auto �6    5*      ��%+   '��       7  �� 5+      8   " ��65   5,      .+�5.   
   ��   LeftContainerMargins#���  6    5/      ��%�   '��       7  �� 50   	   8   " ��69   .�51   
   ��  � ��$ 13.333(�6%   �� 52   
    �@��Padding$ 5q�6$   53   
   54   	   ._�55      *   $Infragistics.Controls.Charts.Heatmap  -   5          Name$ Heatmap��55         ValueMemberPath$ PropertyTwo��56   :      	RowFormat$ {Symbol}��57   9      ColumnFormat$ {0:dd/MM/yy}��58   <      ItemToolTip# [  59         DisplayMode$
 None=�5:         	TextWidth$ 64Q�5;        ForegroundBrush#��[ 5A       	 HighlightStyle   HighlightStyle# [	 66    
 HeatmapStroke   Stroke# � 
 6g      ItemsSource 56      �� *Data+   
RowsSource 57      �� *Rows+   ColumnsSource 58      �� *Cols+   
ValueScale 5B      �� *	SetColors+5D      5E      %   Infragistics.Common.ColorLegend  5F   
   $��1��6   $��12q�6-   $��48��69   $	��180��6D   $��Right=�6Q   $��Center=�6m   $��1q�5G      $��16,16,16,30q�63   $��10(�6I      Scale 5H      ��  �� ElementName$ Heatmap��$	 
ValueScale��� 5I   
   $��2��6     RightContainerMargins#���  6!   ._�5J      ��  �� Orientation$ Vertical=�6   .+�5K      d� -   5        $��Update��5K        ToggleButtonStyle#��[ 6F   d� 5L      -   5        $��Smooth Rows��5L      #��[ 6N   d� 5M      -   5        $��Smooth Columns��5M      #��[ 6T   �� 5N      $ 
Horizontal=�6   .+�5O      d� -   5        $
��Grid��5O   #   #��[ 6E   $��Center=�6p   $��0q�6�   �� 5P       �� Orientation$ 
Horizontal=�6   $	��128��66    � Minimum$ 0Q�6B    � Maximum$ 4Q�6N     SliderStyle#��[ 6�   $��8,0,0,0q�6�   $��Center=�6�    � Value 6Z   �� $ Heatmap�� �� Mode$ TwoWay=�$	 StrokeThickness�6�   5Q      �� 5R      $ Vertical=�6   $��Stretch=�64   .+�5S      �� $��
Item Event��6    $��Stretch=�62   #��[ 6P   $��0,12,0,0q�6�   �� 5T      -   5          ��Name$  	MouseOver��5T       $��Stretch=�63   $��0,4,0,0q�6Q   5U      5V      5W      5X      5Y      