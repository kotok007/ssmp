   M S B A M L   `   `   `  ���� E  AMISBolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MISBolnica
MISBolnica      MISBolnica.PacientAddEdit   U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:MISBolnica     -   $	��600��$	��700��  � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�
�������
�������$��2q�.��� ���	#FFEEEEEE � RowDefinitions �� $��40 ��� $��* �.+��� -   $	��Top=�
�������$��0��.+�� $��5q�
������� � ColumnDefinitions �� $	��630 ��� $��60 �.+��� $��Center=�$��Center=�$��0��.+��� -    ��Name$ 	textTitle��$�� ��$��Center=�$��20(�$��Champagne & Limousines)���  �� Orientation$ 
Horizontal=�$��Right=�$��0,0,10,0q�$��1��.+��� -    ��Name$ ButtonFechar��$��30��$��30��$��0q�
������� � ToolTip$' !Закрыть программу����Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Power=�� $��1�� �� ��  �� $��80 ��� $��80 ��� $��80 ��� $��80 ��� $��* ��� $��50 �.+�(  "MaterialDesignThemes.Wpf.ColorZone  $	��340��$��16(�$��5 5 0 0q�
   Mode$
 Light=�$��0��$��0��   CornerRadius$ 2��+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�$
��Left=�.���� .+��� $��5q�$��ФИО*���� -    ��Name$ textFio��$��5 0 5 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите ФИО ...��  $	��340��$��16(�$��5 5 0 0q�$
 Light=�$��0��$��1��$ 2��$ Depth4=�$
��Left=�.���� .+��� $��5q�$��Паспорт���� -   $ textPasport��$��5 0 5 0q�$B <Введите серию и номер паспорта ...��  $	��340��$��16(�$��5 5 0 0q�$
 Light=�$��1��$��0��$ 2��$ Depth4=�$
��Left=�.���� .+��� $��5q�$ ��Дата рождения*���� -   $ textBorn��$��5 0 5 0q�$2 ,Введите дату рождения ...��  $	��340��$��16(�$��5 5 0 0q�$
 Light=�$��1��$��1��$ 2��$ Depth4=�$
��Left=�.���� .+��� $��5q�$��
Адрес���� -   $ 	textAdres��$��5 0 5 0q�$8 2Введите адрес проживания ...��  $	��340��$��16(�$��5 5 0 0q�$
 Light=�$��2��$��0��$ 2��$ Depth4=�$
��Left=�.���� .+��� $��5q�$��Диагноз МКБ*���� $ 
Horizontal=�.+��� -	   $ textMkb��$	��278��$��5 0 5 0q�$0 *Выберите диагноз МКБ ...�� �� 
IsReadOnly . �� -
   $ buttonAddMkb��$��0 0 5 0q�$9 3Добавить МКБ из справочника��.��. . .  $	��340��$��16(�$��5 5 0 0q�$
 Light=�$��2��$��1��$ 2��$ Depth4=�$
��Left=�.���� .+��� $��5q�$��Состояние���� -   $ textSostoyanie��$��5 0 5 0q�$I CВведите состояние при поступлении ...��  $	��340��$��16(�$��5 5 0 0q�$
 Light=�$��3��$��0��$ 2��$ Depth4=�$
��Left=�.���� .+��� $��5q�$��Отделение*���� $ 
Horizontal=�.+��� -   $ textOtdelenie��$	��278��$��5 0 5 0q�$- 'Выберите отделение ...�� . �� -   $ buttonAddOtdelenie��$��0 0 5 0q�$E ?Добавить отделение из справочника��.��. . .  $	��340��$��16(�$��5 5 0 0q�$
 Light=�$��3��$��1��$ 2��$ Depth4=�$
��Left=�.���� .+��� $��5q�$��Примечание���� -   $ textPrimechanie��$��5 0 5 0q�$- 'Введите примечание ...��  $��2��$	��687��$��16(�$��5 5 0 0q�$
 Light=�$��4��$��0��$ 2��$ Depth4=�$
��Left=�.���� .+��� $��5q�$2��,Диагноз при поступлении���� -   $ textDiagnoz��$��5 0 5 0q�$E ?Введите диагноз при поступлении ...�� �� AcceptsReturn . $	��120���� -   $��savePacient��$��5��$��0��$	��150��$
��Left=�$��Center=�$��СОХРАНИТЬ��$��
150 0 0 10q��� -   $��editPacient��$��5��$��0��$	��150��$
��Left=�$��Center=�$��ИЗМЕНИТЬ��$��
150 0 0 10q��� -   $��showPacient��$��5��$��0��$	��150��$
��Left=�$��Center=�$��OK��$��
150 0 0 10q��� -   $��	cancelAdd��$��5��$��1��$	��150��$��Right=�$��Center=�$��ОТМЕНА��$��
0 0 150 10q�