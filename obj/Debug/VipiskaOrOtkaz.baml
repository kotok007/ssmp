   M S B A M L   `   `   `  ����E  AMISBolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MISBolnica
MISBolnica  5   	       MISBolnica.VipiskaOrOtkaz   5   	   U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MISBolnica     5   	   -   5        $	��400��5	   	   $	��400��6     � WindowStartupLocation$  CenterScreen=�6"    � 
ResizeMode$ NoResize=�6G    � WindowStyle$
 None=�6]   
�������
�������$��2q�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      .+�5   
   �� -   5        $	��Top=�5      
�������$��0��6@   .+�5      � $��5q�6   
������� � ColumnDefinitions 5      �� 5      $	��330 �6'   �� 5      $��60 �6'   .+�5      �� $��Center=�6   $��Center=�6:   $��0��6U   .+�5      �� -   5         ��Name$ 	textTitle��5       $�� ��63   $��Center=�6;   $��20(�6V   $��Champagne & Limousines)�6d   5      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�66   $��0,0,10,0q�6R   $��1��6d   .+�5      �� -   5         ��Name$ ButtonFechar��5      $��30��63   $��30��6>   $��0q�6w   
������� � ToolTip$ Закрыть окно��6�   ��6J   Z� ��6`   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Power=�62   5      5       5!      5"      � 5#   
   $��1��6    5$      �� 5%      $	��100 �6    �� 5&      $	��150 �6    �� 5'      .+�5)      (  "MaterialDesignThemes.Wpf.ColorZone  $	��380��6'   $��16(�63   $��5 10 0 0q�6A   
   Mode$
 Light=�6S   $��0��6`      CornerRadius$ 2��6m   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6~   $
��Left=�6�   .��5*      �� .+�5+      �� -   5        $ 	blockDate��5+       $��5q�63   $��Дата выписки*��6>   (  "System.Windows.Controls.DatePicker  5,      -   5          Name$ textDate��5,   !      SelectedDateFormat$ Short=�63      Text$ 
01.01.2020��6N   5-      5.      5/        50      $	��380��6'   $��16(�63   $��5 10 0 0q�6A   $
 Light=�6S   $��1��6`   $ 2��6m   $ Depth4=�6~   $
��Left=�6�   .��51      �� .+�52      �� -   5        $ blockAll��52       $��5q�62   $��Текст*��6=   �� 53      -   5         ��Name$ textDiagnoz��53      $��5 0 5 0q�63   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Введите текст ...��6D    �� AcceptsReturn . $	��120��6�   6�   54      55      �� 56      -	   5        $
��save��56   .   $��2��6   $	��150��6"   $
��Left=�6:   $��Center=�6U   $��СОХРАНИТЬ��6p   $��40 0 0 0q�6�   6�   �� 57      -
   5        $��save1��57   .   $��2��6   $	��150��6"   $
��Left=�6;   $��Center=�6V   $��СОХРАНИТЬ��6q   $��40 0 0 0q�6�   6�   �� 58      -   5        $��cancel��58   .   $��2��6   $	��150��6"   $��Right=�6<   $��Center=�6X   $��ОТМЕНА��6s   $��0 0 40 0q�6�   6�   59      5<      5=      