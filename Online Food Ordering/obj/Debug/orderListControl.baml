   M S B A M L   `   `   `  ����O  KOnline Food Ordering, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Online_Food_OrderingOnline_Food_Ordering  5      +    %Online_Food_Ordering.orderListControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Online_Food_Ordering     5      .��5
      �� $��
20 0 20 20q�6     �� Orientation$  Vertical=�6%   .+�5      �� $��Center=�6   $  
Horizontal=�66   .+�5      �� $��Center=�6   $��
25 0 25 0 q�6;   .+�5      �� -   5         ��Name$ newOrder_Label��5      $��16 0 0 0q�64   $�� ��6F   $��70(�6Q   $
��Bold"�6_   5      �� 5      $��
New Orders��6   $��15(�61   5      5      �� 5      $��Stretch=�6   $��1��68   $	��100��6B   $��2q�6O   
�������6Z   �� 5      $��
25 0 25 0 q�6   .+�5      �� -   5        $ delivered_label��5      $��10 0 0 0q�65   $�� ��6G   $��70(�6S   $
��Bold"�6a   5      �� 5      $��	Delivered��6   $��15(�60   5      5       �� 5!      $��Stretch=�6   $��1��68   $	��100��6B   $��2q�6O   
�������6Z   �� 5"      $��
25 0 25 0 q�6   .+�5#      �� -   5        $ cancelled_label��5#      $�� ��65   $��10 0 0 0q�6@   $��70(�6R   $
��Bold"�6`   5$      �� 5%      $��	Cancelled��6   $��15(�61   5&      5'      �� 5)      $��Stretch=�6   $��1��68   $	��100��6B   $��2q�6O   
�������6Z   �� 5*      $��
25 0 25 0 q�6   .+�5+      �� -   5        $ amount_label��5+      $�� ��62   $��13 0 0 0q�6=   $��70(�6O   $
��Bold"�6]   5,      �� 5-      $��Amount��6   $��Center=�6-   $��15(�6J   5.      5/      52      &   System.Windows.Controls.DataGrid  54   
   -   5          Name$ 	gridView1��54         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6&   $	��200��66   $��0 40 0 0q�6C      	RowHeight$ 25Q�6U   $	��700��6d      AlternatingRowBackground
 ��ح�   HeadersVisibility$ Column=�6�   57      �� 58      $��Center=�6   $��0 10 0 0q�67   .+�59      �� $��Center=�6   $��Change delivery Status��65   5;      �� 5<      $��0,10,0,0q�6   $��Center=�6+   $  
Horizontal=�6H   .+�5=      �� $��ID��6   5>      �� 5?      -   5         ��Name$ id_tb��5?      $	��100��6-   .��69   5@      5A      �� 5B      -   5         ��Name$ status_comboBox��5B      $	��200��64   $��30��6@   $��0,10,0,0q�6M   .@�5C      �� $��Pending��6#   	 �� 
IsSelected	 . 5D      �� 5E      $��	Delivered��6#   5F      �� 5G      $��	cancelled��6#   5H      5I      �� 5J      -   5        $��
update_btn��5J   [   $��0 7 0 0q�6   $��Center=�6*   
�������$	��100��6o   $��35��6{   $��0q�6�   .��5K      �� $  
Horizontal=�6!   $��Center=�6:   .+�5L      �� $��Resources/update.png��6    5M      �� 5N      $��6 0 0 0q�6    .��61   Update69   5O      5Q      5R      5U      5V      