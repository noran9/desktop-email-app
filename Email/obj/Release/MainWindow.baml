   M S B A M L   `   `   `  ���� @  <Email, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:EmailEmail      Email.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Email     X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  
MainWindow��$	��450��$	��800�� � 	Resources  �� 
TargetType �� Property �� Value��%K   '��       �� " ��.���  � ��$ Corbel)���  � ��$ Normal$�.���  J� RenderTransformOrigin$ 0.5,0.5&�
������� � ColumnDefinitions �� $
��0.7* ��� $
��1.5* ���  � RowDefinitions �� $��65 ��� �� $��2* �.+��� $��1��$��0��
�������$��2q�$��2��._��� .+�9�  9� 
IsExpanded . .��R� $	��250��$��1��$��0��.@�Q� $��Hotmail Account��$��0,10,0,0q�	 Q� 
IsExpanded	 . .@�Q� -   ���� $	��100��$��5q�.���� 
 �� Orientation$
 
Horizontal=�.+��� $V��PC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\inbox.png��$��5q��� $��Center=�._��� InboxQ� -   ���� $	��100��$��5q�.���� $
 
Horizontal=�$��Center=�.+��� $U��OC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\sent.png��$��5q��� $��Center=�._��� SentQ� -   ���� $	��100��$��5q�.���� $
 
Horizontal=�$��Center=�.+��� $W��QC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\delete.png��$��5q��� ._��� $��Center=�TrashQ� $��Gmail Account��.@�Q� -   ���� $	��100��$��5q�.���� $
 
Horizontal=�.+��� $V��PC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\inbox.png��$��5q��� $��Center=�._��� InboxQ� -   ���� $	��100��$��5q�.���� $
 
Horizontal=�$��Center=�.+��� $U��OC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\sent.png��$��5q��� $��Center=�._��� SentQ� -   ���� $	��100��$��5q�.���� $
 
Horizontal=�$��Center=�.+��� $W��QC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\delete.png��$��5q��� ._��� $��Center=�Trash�� .���� $
��Bold"� �� Padding$ 10q�My Contacts�� -   $��
email_list��$��1��$��1��
�������$��2q�$��2��._��� -   $��	list_view��
�������$��Stretch=����� .R��� 
���   �$��2q�$��Center=�._��� -	   
�������$��Stretch=����� 
�������$��40��$
 
Horizontal=�.+��� $��sender��$
��Bold"�$��5,0,10,0q����� *Sender+�� $��subject��$��0,0,15,0q����� *	Subject+�� $
��date������ *date+��  ��Name$
 body��$y�	Collapsed=����� *Body+�� -
   $��
email_view��$��1��$��2��
�������$��2q�$��2��._��� $��1��$��2��$��10q�
�������.+�`� .�c� .@��� $��0��$��3q�
������ .���� $V��PC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\reply.png���� $��1��$��3q�.���� $Z��TC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\reply-all.png���� $��2��$��3q�.���� $X��RC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\forward.png���� -   $��2��$��3q�.���� $W��QC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\delete.png���� -   $��title�� �� TextAlignment$ Center=�$
��Bold"�$��10q�
�������$��20���� -   $��message��$	��230��$��
15,0,15,15q�{�.  �� -   $��0��$��0��$��5q�.���� $
 
Horizontal=�$��10q�.+��� $��Uniform=�$T��NC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\new.png��$��5q�$��20��$��21��$ 	0.524,0.5&��� $��Center=�._��� $ Center=�$��11(�	New Email�� $��1��$��0��$
 
Horizontal=�.+��� $��10q�.+��� Search�� $	��150��.�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 3Q�   Opacity$	 0.8Q�.���� $��10q�$
 
Horizontal=�.+��� $��Center=�._��� Select Layout�� -   $��10, 5q�.���� $U��OC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\list.png��$��5q��� -   $
��10,5q�.���� $W��QC:\Users\norchi\Documents\Human - Computer Interaction\Email\Email\img\list_2.png��$��5q�]� $��2��$��0��$��0,-2,0,2q�.+��� 
�������$��1q�$��Bottom=�$
��0,15q�$��Center=�$��Center=�._�o� $��20, 5q�����  �� EndPoint$ 0.5,1&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	LightBlue�� � Offset$ 1Q�� $ White��.@�m� -   $��Import Emails��m� -   $��Export Emails��