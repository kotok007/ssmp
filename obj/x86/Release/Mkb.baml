   M S B A M L   `   `   `  ���� E  AMISBolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MISBolnica
MISBolnica      MISBolnica.Mkb   U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:MISBolnica     -     N� Title$!  О разработчике�� N� 
Background
 ����� N� FontSize$ 20(� N� 
FontFamily$ Champagne & Limousines)�.���  � RowDefinitions �� $��50 ��� $	��300 ��� $
��Auto �.+��� $��0��$��Center=�.+��� -    ��Name$ currentTextHeader��$��Center=�Справочник МКБ:�� $��0��$��Center=�.+��� -    ��Name$ buttonPrint��$��	10 0 15 0q� � ToolTip$ Печать��$��Right=�$��50��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=��� $��1��.+�&   System.Windows.Controls.DataGrid  -   	  Name$	 DataGridMkb��$	��300��
   SelectionMode$
 Single=�#  MaterialDesignThemes.Wpf.Card  $��2��$	��155��$��10q�
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�.���  �� $��70 ��� $
��Auto �.+�(  "MaterialDesignThemes.Wpf.ColorZone  $��	10 10 0 0q�   Mode$ Light=�$��0��   CornerRadius$ 2��$ Depth4=�$	��730��$
��Left=�.����  �� Orientation$ 
Horizontal=�$��10q�.+��� -    ��Name$ textFind��$��5 0 5 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$9 3Введите то, что надо найти ...��$	��522���� -   $ 
buttonFind��$��25 0 5 0q�$" Найти в таблице��.��  $ Search=��� -   $ buttonFindCancel��$��25 0 5 0q�$! Отменить поиск��.��  $ Close=�  $��	12,15,0,0q�$ Light=�$��1��$ 2��$ Depth4=�$	��730��$
��Left=�.���� $ 
Horizontal=�$��10q�.+��� -   $ 
textKodMkb��$��5 0 5 0q�$&  Введите код МКБ ...��$	��250���� -	   $ textNazvanie��$��15 0 5 0q�$5 /Введите название по МКБ ...��$	��250���� -
   $ 	buttonAdd��$��25 0 5 0q�$# Добавить запись��.��  $	 Add=��� -   $ buttonDelete��$��25 0 5 0q�$! Удалить запись��.��  $ Delete=�