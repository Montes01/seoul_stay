   M S B A M L   `   `   `  ����E  ASeoul Stay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Seoul_Stay
Seoul_Stay  5   	       Seoul_Stay.Register   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Seoul_Stay     5   	     � Title$  Register��5   	   $	��450��6   $	��800��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      $��7* �6   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��5* �6   �� 5      $��2* �6   .+�5   
   � $��0 10 0 0q�6   ���#aaa$��1��63   $��2��6C    5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      � $��0��6   .+�5      �� $��Center=�6   $��	Username:��63   �� 5      -   5         ��Name$ UserNameInput��5   K   $��Center=�6   $��100 0 300 0q�65   6K   	� 5      -   5         	�Name$ 	maleRadio��5      $��Center=�61   $
��Left=�6L   $��	546,0,0,0q�6g   $
��male��6z   	� 5       $	��Top=�6   $��Right=�66   $��female��6R   $��	0,25,22,0q�6c   5!      � 5"      $��1��6   .+�5#      �� $��Center=�6   $��	FullName:��63   �� 5$      -   5        $ FullNameInput��5$   K   $��Center=�6   $��100 0 300 0q�65   6K   �� 5%      $��Center=�6   $��Number of family members:��63   $
��Left=�6W   $��	457,0,0,0q�6r   �� 5&      -   5        $ FamilyInput��5&   o   $��Center=�6   $��Right=�65   $��30��6Q   $��0 0 50 0q�6\   6o   5'      � 5(      $��2��6   .+�5)      �� $��Center=�6   $��	Birthday:��63   (  "System.Windows.Controls.DatePicker  5*      -   5          Name$ BirthDayInput��5*   N   $��Center=�6   $��100 0 300 0q�68   6N   5+      � 5,      $��3��6   .+�5-      �� $��Center=�6   $��	Password:��63   G� 5.      -   5         G�Name$ PasswordInput��5.   O   $��Center=�6   $��100 0 400 0q�69   6O   �� 5/      $��Center=�6   $��
350 0 50 0q�63   $��ReType:��6G   G� 50      -   5        $ PasswordRepeat��50   N   $��Center=�6   $��
400 0 50 0q�69   6N   51      � 52      $��4��6   .+�53      �� $��Center=�6   $*��$ I agree to the Terms and Conditions��66   �� 54      -   5         ��Name$ 	ViewTerms��54      $
��Left=�6,   $��Center=�6G   
������ ���#00f$��0q�6�   $��View Terms And Conditions��6�   $��	400 0 0 0q�6�   55      56      �� 57   
   -	   5        $��1��57      $��Register And Login��6!   $
��Left=�6>   $��	350,0,0,0q�6Y   $��1��6l   $��Center=�6y   6�   �� 58   
   -
   5        $��2��58      $��Return to login��6!   $
��Left=�6;   $��32,0,0,0q�6V   $��1��6h   $��Center=�6u   6�   �� 59   
   $��4��6   $��3��6   
���   �$��Stretch=�6G   $��2q�6e   5:      5;      