   M S B A M L   `   `   `  ����O  KOnline Food Ordering, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Online_Food_OrderingOnline_Food_Ordering  5   	   !    Online_Food_Ordering.Signup   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Online_Food_Ordering     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Icon$ Resources/main.png��5	   	    � Title$ Signup��5
   	   $	��650��6   $	��850��6%   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��431* �6   �� 5      $
��296* �6   �� 5      $
��116* �6    � RowDefinitions 5   
   .+�5   
   �� $��50,50,50,59q�6   $��0��6%   $��0��65   $
��auto��6C   $
��auto��6Q   ��5      �� 5       �� DecodePixelWidth$	 300��6    �� 	UriSource$ Resources/signup_img.png?�65   5      �� 5   
    �� Orientation$ Vertical=�6   $��40q�6,   $��1��68   $��0��6H   $��2��6U   .+�5      �� $��35(�6   $
��Bold"�6"   $��SignUp��64   �� 5      $��15(�6   $
��Name��6#   �� 5       -   5         ��Name$ signUP_Name_tb��5       $��23��6.   $��5q�6:   	 �� TextWrapping$
	 Wrap=�6E   $�� ��6Y   �� 5"      $��15(�6   $��Email��6#   �� 5#      -   5        $ signUP_Email_tb��5#      $��23��6/   $��5q�6;   $
	 Wrap=�6F   $�� ��6Z   �� 5%      $��15(�6   $��Phone Number��6#   �� 5&      -   5        $ signUP_phone_tb��5&      $��23��6/   $��5q�6;   $
	 Wrap=�6F   $�� ��6Z   �� 5(      $��15(�6   $��Password��6#   G� 5*      -   5        
 G�Name$
 signUP_password_tb��5*      $��23��66   $��5q�6B   6P   �� 5+      $��15(�6   $��Conform Password��6#   G� 5,      -   5        $
 signUP_conformPassword_tb��5,      $��23��6=   $��5q�6I   6W   �� 5-      $(��"I agree to all the Term and Policy��6   $��5q�6D   �� 5.      -   5         ��Name$ 
signUP_btn��5.      $��SIGN UP��6)   $��5q�6;   6F   �� 5/      $M��G-------------------------------OR--------------------------------------��6   �� 50      
�������.��51      �� $ 
Horizontal=�6   $��Center=�66   .+�52      �� $��Resources/google.png��6   54      �� 55      $��6q�6   .��6'   SignIn with Google6;   56      57      �� 58      -   5        
�������$��Already have an account?��58   (   $��0q�6K   
�������$��10q�6s   5:      �� 5;      -   5         ��Name$ message��5;      
���  ��$�� ��66   5<      5>      5?      