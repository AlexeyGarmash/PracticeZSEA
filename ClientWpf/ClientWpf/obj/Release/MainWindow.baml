   M S B A M L   `   `   `  ���� ^  ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration  [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  	ClientWpf   ClientWpf.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _wfiOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration     Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     -     �Name$	  WND�� � Title$ Cipher of Caesar��$��786.93��$
��1281��
���   � � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=�.��� -    �Name$ MainGrid������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF727272�� � Offset$ 0Q�� $ 	#FF898989��$ 1Q�� $ 	#FFF7F7F7��$ 0.332Q�.+��� -   	 ��Name$	 UserDataTextBox��$
��Left=�$	��283��$��	10,44,0,0q�
 �� TextWrapping$
 WrapWithOverflow=�$	��Top=�$	��557��$
��Bold"� � ToolTip$ 
Enter word��$��18(����	#FF1ECDA7$��Stretch=� �� AcceptsReturn . $��0q��� -   $	 ResultTextBox��$
��Left=�$	��283��$��
701,44,0,0q�$

 Wrap=�$	��Top=�$	��557��$
��Bold"�$��18(�$ Result��
���   � �� 
IsReadOnly . �� -   $	 ROTNTextBox��$
��Left=�$��42��$��
621,50,0,0q�$

 Wrap=�$	��Top=�$��66��$
��Bold"�$ Shift��$��18(��� $	��ROT��$
��Left=�$	��Top=�$��
582,56,0,0q�$��39��$��25��$��14(�$
��Bold"�	� -    	�Name$ EncryptRadio��$��Encrypt��$
��Left=�$��576,110,0,0q�$	��Top=� d� 	IsChecked$
 TrueY����	#FF0E0E0E$
��Bold"�$��60��$��9(�	� -   $ DecryptRadio��$��Decrypt��$
��Left=�$��638,110,0,0q�$	��Top=����	#FF0E0E0E$
��Bold"�$��58��$��9(�$��0q��� -    ��Name$ 	GO_Button��$	��GO!��$
��Left=�$��580,143,0,0q�$	��Top=�$	��108��$��28��$ Solve���� -	    ��Name$ ChartCanvas��$
��Left=�$	��351��$��
66,368,0,0q�$	��Top=�$
��1132���� $
��Left=�$��582,336,0,0q�$
��Wrap=�$��Frequencies��$	��Top=�$
��Bold"�$��20(� �� TextAlignment$ Center=��� $
��Left=�$��	10,20,0,0q�$
��Wrap=�$��Put here��$	��Top=�$
��Bold"�$��20(�$ Center=��� $
��Left=�$��
701,22,0,0q�$
��Wrap=�$��Result��$	��Top=�$
��Bold"�$��20(�$ Center=��� -
   $ Enigma_Button��$��Enigma��$
��Left=�$��579,191,0,0q�$	��Top=�$	��108��$��28��$ Guess the shift��