   M S B A M L   `   `   `  ����Z  VStudent_Management_System(MVVM), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Student_Management_System_MVVM_Student_Management_System_MVVM_  5   	   0    *Student_Management_System_MVVM_.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Student_Management_System_MVVM_     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��900��6)   ���	#FF022ACC � DataContext 5	      2   ,Student_Management_System_MVVM_.MainWindowVM  5
   
   .��5      � $�� 250 ,0,0,0q�6   
�������$	��485��64   $��Center=�6A   $
��Left=�6\   $	��600��6w   .+�5   
   �� $	��250��6   $	��500��6!   $
��Left=�6.   $��
-250,0,0,0q�6I    �� Orientation$ Vertical=�6]   $��Center=�6t   .+�5      �� $"��/images-removebg-preview.png��6   $	��254��6:   $	��174��6G   �� 5      $��ADD USER��6      
mainbutten#��[  6(   $��50��6L   ���	#FF1A6DF3$��0,20,0,0q�6o   ��6�   �� *AddUserCommandCommand+�� 5      $��	EDIT USER��6   #��[  6)   $��50��6M   ���	#FF1A6DF3$��0,5,0,0q�6p   ��6�   �� *EditUserCommandCommand+�� 5      $��DELETE USER��6   #��[  6+   $��50��6O   ���	#FF1A6DF3$��0,5,0,0q�6r   ��6�   �� *RemoveUserCommandCommand+�� 5      $
��Exit��6   #��[  6$   $��50��6H   ���	#FF1A6DF3$��0,5,0,0q�6k   ��6|   �� *ExitCommandCommand+ �� Mode$ OneWay=�5      �� 5   
   $ 
Horizontal=�6   $��40,10,10,10q�6.   .+�5      �� $��
First Name��6   $��10,10,10,10q�6*   �� 5      $��	Last Name��6   $��10,10,10,10q�6)   �� 5      $	��Age��6   $��40,10,10,10q�6#   �� 5      $	��Gpa��6   $��60,10,10,10q�6#   �� 5      $
��Date��6   $��50,10,10,10q�6$   �� 5      $��Month��6   $��
1,10,10,10q�6%   �� 5      $
��Year��6   $��
1,10,10,10q�6$   5!      �� 5&   
   -   5         ��Name$ ListView��5&      
�������$��	5,51,0,76q�5'   _   ��5&   8   �� *
Students+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5'      �� *Selectedperson+$ PropertyChanged=���5)      �� 5*      .R�5+      �� 
������ 
���   �$��1q�6J    �� Padding$	 0.1q�5,   !    �� CornerRadius$ 5��6/   $	��575��6@   $��35��6L   ._�5-      �� $	��600��6%   
������ $ 
Horizontal=�6K   .+�5/      �� $��30��6$   $��30��6/   $��1q�6;   ��6F   �� *Image+�� 50        ListView#��[ 6g   ��6(   �� *	FirstName+$ PropertyChanged=�6g   �� 51      #��[ 6f   ��6(   �� *
LastName+$ PropertyChanged=�6f   �� 52      #��[ 6a   ��6(   �� *Age+$ PropertyChanged=�6a   �� 53      #��[ 6a   ��6(   �� *Gpa+$ PropertyChanged=�6a   �� 54      $��10,10,10,10q�6b   ��6(   �� *Date+$ PropertyChanged=�6b   �� 55      $��10,10,10,10q�6d   ��6(   �� *Month+$ PropertyChanged=�6d   �� 56      $��20,10,10,10q�6c   ��6(   �� *Year+$ PropertyChanged=�6c   5=      5?      5@      5L      5S      5T      