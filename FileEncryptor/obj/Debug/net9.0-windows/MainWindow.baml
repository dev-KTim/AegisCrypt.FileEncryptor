   M S B A M L   `   `   `  ����  FileEncryptor    AegisCrypt.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
AegisCrypt��5   	   $	��400��5   	   $	��600��5   	    � 
ResizeMode$ NoResize=�5   	   ��5	      �� 5
   
    �� Color$ #000000��6    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� CornerRadius
 �� Triggers P� Property P� Value �� ScaleX �� ScaleY N� EnterActions �� TargetProperty	 W� To g� Duration W� EasingFunction2  ,System.Windows.Media.Animation.QuadraticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode N� ExitActions��%�  '��       �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ ButtonBorder��6!   
���   �
����p��$��5q�5   !   $	 8��5   !   ._�5      �� $��Center=�6/   $��Center=�5   /   5      5      5      �� 5!       � ��
 ��p��6+   
 5#      P� 5$       �@J�IsMouseOver$
 True��61   . �5&      ��  � z� 5'      �� 5(      scaleTransformHover��$	 1.2Q�6J   $	 1.2Q�6W   5*       5-      �� 5.      .��5/      �� .��50   "   W� $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�51   %    1.252   %   $ 0:0:0.8D�6.    53   &     54   *   $ 	EaseInOut=�68   56   #   W� 57   "   $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�58   %    1.259   %   $ 0:0:1.0D�6.    5:   &     5;   *   $ 	EaseInOut=�68   5=   #   5>      5?      5A      P� 5C       �@J�IsMouseOver$ False��61   . �5E      ��  � z� 5F      �� 5G      scaleTransformDefault��$ 1Q�6L   $ 1Q�6W   5I       5K      �� 5L      .��5M      �� .��5N   "   W� $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�5O   %    15P   %   $ 0:0:0.8D�6,    5Q   &     5R   *   $ 	EaseInOut=�68   5T   #   W� 5U   "   $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�5V   %    15W   %   $ 0:0:1.0D�6,    5X   &     5Y   *   $ 	EaseInOut=�68   5[   #   5\      5]      5_      5a      5b      .��5h      � $��10q�6    � RowDefinitions 5i   
   �� 5j      $
��Auto �6   �� 5k      $��* �6   .+�5n   
   �� $,��&AegisCrypt - Verschlüsselungsprogramm��6   $��25(�5o      $
��Bold"�5p      
����p��$��Center=�5r      $
��0,10q�5s      �� 5u   
   $��1��6   $��Center=�5v      $��Center=�5w      $	��176��62   $	��287��6?   .+�5y      �� -   5        $��EncryptButton��5y      $��Datei verschlüsseln��5z      $	��250��5{      $��45��5|      $��5q�5}      $��18(�5~      $��SemiBold"�5       J� RenderTransformOrigin$ 0.5,0.5&�5�      �� 5�      -   5        $��DecryptButton��5�      $��Datei entschlüsseln��5�      $	��250��5�      $��45��5�      $��5q�5�      $��18(�5�      $��SemiBold"�5�      $ 0.5,0.5&�5�      �� 5�      -   5        $��
ExitButton��5�      $��Beenden��5�      $	��250��5�      $��45��5�      $��5q�5�      $��18(�5�      $��SemiBold"�5�      $ 0.5,0.5&�5�      5�      5�      5�      