   M S B A M L   `   `   `  ����C  ?WPF_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF_MVVMWPF_MVVM  5          WPF_MVVM.MainView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WPF_MVVM     5      -   5        .��5
      ]�   � 	Resources  5   
    �� DataType   WPF_MVVM.itemHostel �� ItemsSource �� Path
 � Tag   WPF_MVVM.itemSection   WPF_MVVM.itemRoom��%�  (��       5   '   *, +)(�� �     5   '   *, +)(�� '    5      *, +)�� 5      "  6'    5   !   �� $ Section�.R�5      �� ��5      �� $ Hostel� 5      �� $ idHostel�5      �� 5      "  6'    5   !   �� $
 Room�.R�5      �� ��5      �� $ SectionName� 5      �� $ 	idSection�5      �� 5      "  6   .R�5      �� ��5      �� $ Number_Room� 5       �� $ idRoom�5"      5#      .+�5%   
   �� $��Bottom=�6   .@�5&      �� .��5'      �� -   5        $��lblCursorPosition��5'      $&�� Количество строк:��65   5(      5)      � 5*   
    � ColumnDefinitions 5+      �� 5,      $
��auto �6#   �� 5-      $��* �6#    � RowDefinitions 5/      �� 50      $
��auto �6    �� 51      $��* �6    .+�54      R� $��0��55      $��0��56      $��2��57      $	��200��58      $��5q�59      ��5;      �� 5<       �� 
TargetType" Q�6   .�5=      ��  �� Property �@Q�
IsSelected	 �� Value	 67   �� *selectedItem+5>      .@�5@      Q� -   5        
 Q�Name$

 tree��5@      $��СПИСОК ЗДАНИЙ��6-   5B      �� 5D      $��0��5E       �� ShowsPreview .  $��4��5G      �� 5I      $��1��6   $��0��5J      $��5 5 5 0q�5L      �� 5O      -   5         ��Name$ SourceCollection��5S      $��1��5P      $��1��5Q      $��5q�5R      ��5U      �� 5V      .R�5W      �� ��6$   �� *
idHostel+5X      5\      5]      5_      5b      