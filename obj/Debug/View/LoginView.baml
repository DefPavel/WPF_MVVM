   M S B A M L   `   `   `  ����C  ?WPF_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF_MVVMWPF_MVVM  5      3clr-namespace:WPF_MVVM.HelpersWPF_MVVM.Helpers  5          WPF_MVVM.LoginView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WPF_MVVM     5      /pwbxclr-namespace:WPF_MVVM.Helpers     5      $	��550��5
      $	��280��5      $��Segoe UI Light)�5      $��14(�5      .��5      �   � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5!   
   �� $��0��5"      $��1��5#      $��2��5$      $��Center=�5%      $��Application in MMV��5&      $��40(�5'      $��	0 20 0 20q�5(      �� 5+   
   $��1��5,      $��1��5-      $ ��Введите логин:��5.      $��5q�5/      $
��Left=�50      �� 52   
   -   5         ��Name$ UserName��53      $��1��54      $��2��55      $	��150��56      $	��320��57      $��5q�58      �� 5;   
   $��2��5<      $��1��5=      $"��Введите пароль:��5>      $��5q�5?      $
��Left=�5@      G� 5C   
   -   5         G�Name$ Password��5D      $��2��5E      $��2��5F      $	��150��5G      $	��320��5H      $��5q�5I      '   !WPF_MVVM.Helpers.BoundPasswordBox   BoundPassword 5J      �� *
Password+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . �� 5Q   
   -   5        	 ��Name$	 	CheckSave��5S      $��3��5T      $��1��5U      $��2��5V      $��12(�5W      $��_Сохранить?��5X      $��5q�5Y      $��Right=�5Z      �� 5]   
   -   5        
 ��Name$
 LoginIn��5^      $��1��5_      $��4��5`      $��2��5a      $��Авторизация��5b      $
��10 5q�5c      $��5q�5d      $��Right=�5e      �� 5g   
   -   5         ��Name$ ErrorMessage��5m      $��5��5n      $��1��5o      $��2��5p      
���  ��$��5q�5r      $	��300��5s      $
��Wrap=�5t      $��Center=�5u      y�5h      �� *IsErrorVisible+    BooleanToVisibilityConverter �� 	Converter# [   �� FallbackValue$ 	Collapsed��5u      5w      5x      