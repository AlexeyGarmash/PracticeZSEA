   M S B A M L   `   `   `  ����^  ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration  5   	   [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5   	    	ClientWpf   ClientWpf.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _wfiOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   -   5          �Name$	  WND��5   	    � Title$ Cipher of Caesar��5   	   $��786.93��6"   $
��1281��62   
���   � � 
ResizeMode$ CanMinimize=�6S    � WindowStartupLocation$ CenterScreen=�6l   .��5      � -   5         �Name$ MainGrid��5      ��5   
   �� 5	       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5
      �  � Color$ 	#FF727272��6    � Offset$ 0Q�61   � 5      $ 	#FF898989��6   $ 1Q�61   � 5      $ 	#FFF7F7F7��6   $ 0.332Q�61   5      .+�5   
   �� -   5        	 ��Name$	 UserDataTextBox��5      $
��Left=�6+   $	��283��6F   $��	10,44,0,0q�6S   
 �� TextWrapping$
 WrapWithOverflow=�6f   $	��Top=�6�   $	��557��6�   $
��Bold"�6�    � ToolTip$ 
Enter word��6�   $��18(�6�   ���	#FF1ECDA7$��Stretch=�6�    �� AcceptsReturn . $��0q�60  �� 5   
   -   5        $	 ResultTextBox��5      $
��Left=�6)   $	��283��6D   $��
701,44,0,0q�6Q   $

 Wrap=�6e   $	��Top=�6y   $	��557��6�   $
��Bold"�6�   $��18(�6�   $ Result��6�   
���   � �� 
IsReadOnly . 6�   �� 5   
   -   5        $	 ROTNTextBox��5      $
��Left=�6'   $��42��6B   $��
621,50,0,0q�6N   $

 Wrap=�6b   $	��Top=�6v   $��66��6�   $
��Bold"�6�   $ Shift��6�   $��18(�6�   6�   �� 5   
   $	��ROT��6   $
��Left=�6   $	��Top=�69   $��
582,56,0,0q�6Q   $��39��6e   $��25��6p   $��14(�6|   $
��Bold"�6�   	� 5   
   -   5         	�Name$ EncryptRadio��5      $��Encrypt��6,   $
��Left=�6>   $��576,110,0,0q�6Y   $	��Top=�6n    d� 	IsChecked$
 TrueY�6�   ���	#FF0E0E0E$
��Bold"�6�   $��60��6�   $��9(�6�   	� 5   
   -   5        $ DecryptRadio��5      $��Decrypt��6,   $
��Left=�6>   $��638,110,0,0q�6Y   $	��Top=�6n   ���	#FF0E0E0E$
��Bold"�6�   $��58��6�   $��9(�6�   $��0q�6�   �� 5   
   -   5         ��Name$ 	GO_Button��5      $	��GO!��6$   $
��Left=�62   $��580,143,0,0q�6M   $	��Top=�6b   $	��108��6z   $��28��6�   $ Solve��6�   �� 5   
   -	   5         ��Name$ ChartCanvas��5      $
��Left=�6&   $	��351��6A   $��
66,368,0,0q�6N   $	��Top=�6b   $
��1132��6z   �� 5   
   $
��Left=�6   $��582,336,0,0q�6/   $
��Wrap=�6D   $��Frequencies��6X   $	��Top=�6k   $
��Bold"�6�   $��20(�6�    �� TextAlignment$ Center=�6�   �� 5   
   $
��Left=�6   $��	10,20,0,0q�6/   $
��Wrap=�6B   $��Put here��6V   $	��Top=�6f   $
��Bold"�6~   $��20(�6�   $ Center=�6�   �� 5   
   $
��Left=�6   $��
701,22,0,0q�6/   $
��Wrap=�6C   $��Result��6W   $	��Top=�6e   $
��Bold"�6}   $��20(�6�   $ Center=�6�   �� 5   
   -
   5        $ Enigma_Button��5      $��Enigma��6(   $
��Left=�69   $��579,191,0,0q�6T   $	��Top=�6i   $	��108��6�   $��28��6�   $ Guess the shift��6�   5      5      