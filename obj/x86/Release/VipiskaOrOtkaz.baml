   M S B A M L   `   `   `  ���� E  AMISBolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MISBolnica
MISBolnica      MISBolnica.VipiskaOrOtkaz   U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:MISBolnica     -   $	��400��$	��400��  � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�
�������
�������$��2q�.���  � RowDefinitions �� $��40 ��� .+��� -   $	��Top=�
�������$��0��.+�� $��5q�
������� � ColumnDefinitions �� $	��330 ��� $��60 �.+��� $��Center=�$��Center=�$��0��.+��� -    ��Name$ 	textTitle��$�� ��$��Center=�$��20(�$��Champagne & Limousines)���  �� Orientation$ 
Horizontal=�$��Right=�$��0,0,10,0q�$��1��.+��� -    ��Name$ ButtonFechar��$��30��$��30��$��0q�
������� � ToolTip$ Закрыть окно����Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Power=�� $��1�� �� $	��100 ��� $	��150 ��� .+�(  "MaterialDesignThemes.Wpf.ColorZone  $	��380��$��16(�$��5 10 0 0q�
   Mode$
 Light=�$��0��   CornerRadius$ 2��+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�$
��Left=�.���� .+��� -   $ 	blockDate��$��5q�$��Дата выписки*��(  "System.Windows.Controls.DatePicker  -     Name$ textDate��   SelectedDateFormat$ Short=�   Text$ 
01.01.2020��  $	��380��$��16(�$��5 10 0 0q�$
 Light=�$��1��$ 2��$ Depth4=�$
��Left=�.���� .+��� -   $ blockAll��$��5q�$��Текст*���� -    ��Name$ textDiagnoz��$��5 0 5 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Введите текст ...�� �� AcceptsReturn . $	��120���� -	   $
��save��$��2��$	��150��$
��Left=�$��Center=�$��СОХРАНИТЬ��$��40 0 0 0q��� -
   $��save1��$��2��$	��150��$
��Left=�$��Center=�$��СОХРАНИТЬ1��$��40 0 0 0q��� -   $��cancel��$��2��$	��150��$��Right=�$��Center=�$��ОТМЕНА��$��0 0 40 0q�