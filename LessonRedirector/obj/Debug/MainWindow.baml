   M S B A M L   `   `   `  ����P  LOnlineClassRedirector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LessonRedirectorLessonRedirector  5   	   !    LessonRedirector.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:LessonRedirector     5   	   -   5          � Title$   ��5   	   $	��482��6   $	��462��6    � WindowState$ Normal=�6=    � WindowStyle$
 None=�6R    � ShowInTaskbar .  
������  � 
ResizeMode$ NoResize=�6�    � WindowStartupLocation$ CenterScreen=�6�   .��5	      � .+�5
   
   �� -   5         ��Name$ Image��5
      $��0,0,0,20q�6    J� Opacity$	 0.5Q�61   ��5      �� 5       �� 	UriSource$  ?�6   5      �� 5   
   -   5        	 ��Name$
	 Send��5      $��
Yönlendir��6   $��Center=�63   $��	0,250,0,0q�6P   $��Center=�6c   $��75��6~   $y�Hidden=�6�   6�   �� 5   
   -   5        $	 Option1Button��5      $��
Yönlendir��6(   $��Center=�6<   $��0,250,110,0q�6Y   $��Center=�6n   $	��105��6�   $y�Hidden=�6�   6�   �� 5   
   -   5        $	 Option2Button��5      $��
Yönlendir��6(   $��Center=�6<   $��110,250,0,0q�6Y   $��Center=�6n   $	��105��6�   $y�Hidden=�6�   6�   �� 5   
   -   5        
 ��Name$
 	CloseText��5      $�� ��6#   $��Center=�6.   $��	0,200,0,0q�6K   $��Center=�6^   $y�Hidden=�6y   �� 5   
   -   5        $	 CloseButton��5      $��Şimdi Kapat��6&   $��Center=�6<   $��	0,250,0,0q�6Y   $��Center=�6l   $��75��6�   $y�Hidden=�6�   �� 5   
   -   5        $
 Timer��5      $��Label��6   $��Center=�6/   $��0,10,0,0q�6L   $	��Top=�6^    �� TextAlignment$ Center=�6v   $��18(�6�   �� 5   
   -	   5        $
 Subject��5      $��Yükleniyor��6!   $��Center=�66   $��	0,0,0,100q�6S   $��Center=�6f   $��32(�6�   $��1q�6�   � 5   
   -
   5         �Name$	 Bar��5      $��Center=�6#   $��20��6@   $��Bottom=�6L    � Maximum$	 375Q�6g   $��0��6u   �� 5   
   -   5        $
 MinutesLeft��5      $��Dakika Kaldı��6%   $��Center=�6<   $��0,0,0,10q�6Y   $��Center=�6k   $��20(�6�   $y�Hidden=�6�   �� 5   
   -   5        $	 
HelpButton��5      $$��Aradığım Dersi Bulamıyorum��6%   $��Center=�6J   $��	0,350,0,0q�6g   $��Center=�6z   $y�Visible=�6�   5      5      