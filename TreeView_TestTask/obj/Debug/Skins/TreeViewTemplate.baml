   M S B A M L   `   `   `  ����L  HTreeView_TestTask, Version=0.0.0.1, Culture=neutral, PublicKeyToken=nullS.clr-namespace:TreeView_TestTask.Infrastructure TreeView_TestTask.Infrastructure  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   
GlyphBrush  �� Color  ExpandCollapseToggleStyle �� 
TargetType �� Property �� Value �� 
TargetType F�Name �� Triggers P� Property P� Value	 �� 
TargetName  TemplateStyle
 �� Mode-   'System.Windows.Input.KeyboardNavigation � 	ResourcesD   >TreeView_TestTask.Infrastructure.LeftMarginMultiplierConverter  Key   Length ��Name �� Padding  lengthConverter �� 	Converter �� RelativeSource � ColumnDefinitions d�Name �� 	ClickMode d� 	IsChecked �� Path ��Name ��Name ]� 
Conditions �� Property �� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      8local.clr-namespace:TreeView_TestTask.Infrastructure  5      %�	  &	        &	      7   &	 4    7  7  �� 5      $
  #444��6)   �� 5      " d�6.   .�5	   
   ��  � |� .  6&   �� 5
   
    � �� 5      �� 5      " d�6"   .R�5      � $��15��5      $��13��5      
������ .+�5      F� $ 
ExpandPath��5      $��1,1,1,1q�5      $
��Left=�5      $��Center=�5      "���� 	=     � z  	= � 	=  z 	8��  5      5       5      P� 5       �@d�	IsChecked$
 TrueY�67   . �5      �� $	 
ExpandPath��6%    � ��" ��     	= � z  	= � 	=  z 	6M   5      5      5       5!      �� 5#      " Q�6"   .�5$   
   ��  �@Q�
IsExpanded 6'   �� *
IsExpanded+$
 TwoWay=��� 5%   
    �@  AcceptsReturn . 6=   �� 5'   
    � ��$ 1q�6,   �� 5(   
    � �� 5)      �� 5*      " Q�6"    5+      ��  5,      lengthConverter $ 19Q�6V   5-      .R�5.      �� .+�5/      �� $ Bd��50      # z��51      #��z��52      #��z��53      #��z��54      ._�55      � ��6#   �� 8    �� *TemplatedParent+ 56   "   �� 57   &   $��19 �67   �� 58   &   .+�5:   "   d� $ Expander��5;   %   $ Press=�5<   %   8��  5=   %   �� $ 
IsExpanded� �� *TemplatedParent+5>   %   �� 5@   "   $ PART_Header��5A   %   $��1��5B   %   $��Stretch=�5C   %   $��Stretch=�5D   %   $��Header��5E   %   5F      5G      �� 5H      $ 	ItemsHost��6)   5I       5J      P� 5K       �@Q�
IsExpanded .  . �5L      �� $	 	ItemsHost��6%    � y�$ 	Collapsed=�6R   5M      P� 5N       �@��HasItems .  . �5O      �� $	 Expander��6%    � y�$ Hidden=�6Q   5P      ]� 5Q       5R      �� 5S   "    � �� .  6A   �� 5T   "    � ��$
 Auto��6=   ./�5V      �� $	 PART_Header��6%    � ��$ 75��6R   5W      ]� 5X       5Y      �� 5Z   "    � �� .  6A   �� 5[   "    � ��$
 Auto��6>   ./�5]      �� $	 PART_Header��6%    � ��$ 19��6S   5^      P� 5_       �@Q�
IsSelected . . �5`      �� $	 Bd��6%   # � ��6K    � ���� 5b      # � ��6;    � ��5c      ]� 5d       5e      �� 5f   "    �@Q�
IsSelected . 6B   �� 5g   "    �@Q�IsSelectionActive .  6I   ./�5i      �� $	 Bd��6%   # � ��6K    � ���� 5k      # � ��6;    � ��5l      P� 5m       � {� .  . �5n      �� # � ��6;    � ��5o      5q      5s      5u      5z      