   M S B A M L   `   `   `  ����B  >PTRKApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PTRKApp.STRPTRKApp.STR  5          PTRKApp.STR.AddGroup   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:PTRKApp.STR     5        N� Title$  AddGroup��5	      .��5      � .+�5   
   �� $��/q3.png��6   $
��Fill=�6!   �� 5   
   $��Center=�6   $��Center=�62   .+�5      �� $��ID Команды��6   $��5q�6+   $��18(�66   $
��Bold"�6D   �� 5      -   5         ��Name$ TextBox1��5      ��6(   �� *
id_group+�� 5      $%��Название команды��6   $��5q�61   $��18(�6<   $
��Bold"�6J   �� 5      -   5        $ TextBox2��5      ��6(   �� *
Name_group+&   System.Windows.Controls.DataGrid  5      -   5          Name$ SborDG��5   E      AutoGenerateColumns .     
IsReadOnly . $	��100��6U   $	��400��6b   $��5q�6n      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$# ФИО специалиста��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *FIO+5      �� 5      -   5         ��Name$ 
AddSborCmb��5      	 �� DisplayMemberPath$		 FIO��6+   $��5q�6C   $	��150��6N   $��30��6Z   �� 5      -   5        
 ��Name$
 
AddSborBtn��5      $��Добавить��6)   $��5q�6<   $	��150��6G   $��30��6S   6_   �� 5      -   5        $
 
DelSborBtn��5      $��Удалить��6)   $��5q�6;   $	��150��6F   $��30��6R   6^   �� 5      -   5        $
 SaveBtn��5      $��Сохранить��6&   $��5q�6:   $	��150��6E   $��30��6Q   6]   �� 5      -   5        $
 BackBtn��5      $��
Назад��6&   $��5q�66   $	��150��6A   $��30��6M   6Y   5      5      5      