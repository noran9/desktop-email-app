   M S B A M L   `   `   `  ���� @  <Email, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:EmailEmail      Email.SendEmail   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Email     X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  	SendEmail��$	��600��$	��650��.��� 
������� � ColumnDefinitions �� �� $��3* �.+��� $��1��
�������$��10q�._��� 
�������$��Stretch=�$��0,2,0,-2q�.+��� $��16(�$��Center=�$��10q�Compose New Email�� -   $��error��$
��Bold"�
���  ��$
��10,0q��� $��10, 0q�	Recipient�� -    ��Name$ 	recipient��$��10, 5q��� $��10, 0q�Copy�� -   $
 copy��$��10, 5q��� $��10, 0q�	Subject�� -   $ subject��$��10, 5q�   Email.Editor  -     Name$
 body��$	��200��$��10, 5q���  �� Orientation$ 
Horizontal=�.+��� -    ��Name$ addAttachments��$��Add Attachments��$��10, 3q�$	��150��$
��Left=�$��30��	� -   $��sendImm�� 	� 	GroupName$ 	sendLater��$��Center=�$��10, 3q� d� 	IsChecked$
 TrueY�.��Send Immediately	� -   $��	sendLater��$ 	sendLater��$��Center=�$��10, 3q�.��
Send later�� -	   $ 	sendEmail��$��10q�$��
Send Email��$
��Bold"�$��30���� $��0��.+��� -
   $��0��$
��Back��$��30��$��20q�$
��Bold"�$	��Top=��� $��14(�$
��10,5q�Attachments�� -    ��Name$ lbAttachments��$
��10,5q����� .R��� 
�������$��1q�._��� -   $��Stretch=�$��10q����� $ 
Horizontal=�$��3q�.+��� $��50��$��50������ *Path+(  "Xceed.Wpf.Toolkit.MagnifierManager	   	Magnifier	 !  Xceed.Wpf.Toolkit.Magnifier  
   Radius$	
 100Q�   
ZoomFactor$ .3Q��� $��12(�$
��10,5q�$��Center=����� *
FileName+r� -   $��media�� r� LoadedBehavior$ Manual=�$
��10,5q�$y�Hidden=��� $ 
Horizontal=�$��Center=�.+��� -   $
��play��$y�Hidden=�$��10q�$��20��$��20��.���� $E��?C:\Users\norchi\Documents\Human - Computer Interaction\play.png���� -   $��pause��$y�Hidden=�$��10q�$��20��$��20��.���� $V��PC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\pause.png���� -   $��slider��$y�Hidden=�$��10q�