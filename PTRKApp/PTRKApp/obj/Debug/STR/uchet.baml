   M S B A M L   `   `   `  ����B  >PTRKApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PTRKApp.STRPTRKApp.STR  5          PTRKApp.STR.uchet   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:PTRKApp.STR     5        N� Title$  uchet��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SborTab��5      $��Stretch=�6$      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID учета��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
id_uchet+  5      $ ID заказа��6%    68   �� *
id_product+  5      $ ID команды��6%    69   �� *
id_group+  5      $ Дней работы��6%    6:   �� *
Days_sbora+  5      $ Оплата заказа��6%    6<   �� *
kg_sbora+  5      $( "Дата начала работы��6%    6A   �� *
Date_sbora+5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� -   5        	 ��Name$	 Button2��5      $��Добавить��6&   $��5q�69   $��30��6D   $	��150��6P   6\   �� 5      -   5        $	 Button3��5      $��Удалить��6&   $��5q�68   $��30��6C   $	��150��6O   6[   �� 5      -   5        $	 Button5��5      $��
Назад��6&   $��5q�66   $��30��6A   $	��150��6M   6Y   5      5      5       