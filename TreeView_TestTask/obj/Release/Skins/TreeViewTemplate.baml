   M S B A M L   `   `   `  ���� L  HTreeView_TestTask, Version=0.0.0.1, Culture=neutral, PublicKeyToken=nullS.clr-namespace:TreeView_TestTask.Infrastructure TreeView_TestTask.Infrastructure  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   
GlyphBrush  �� Color  ExpandCollapseToggleStyle �� 
TargetType �� Property �� Value �� 
TargetType F�Name �� Triggers P� Property P� Value	 �� 
TargetName  TemplateStyle
 �� Mode-   'System.Windows.Input.KeyboardNavigation � 	ResourcesD   >TreeView_TestTask.Infrastructure.LeftMarginMultiplierConverter  Key   Length ��Name �� Padding  lengthConverter �� 	Converter �� RelativeSource � ColumnDefinitions d�Name �� 	ClickMode d� 	IsChecked �� Path ��Name ��Name ]� 
Conditions �� Property �� Value�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     8local.clr-namespace:TreeView_TestTask.Infrastructure  %�  &	        &	      7   &	 B    7  7  �� $
  #444���� " d�.���  � |� .  ��  � �� �� " d�.R�� $��15��$��13��
������ .+�F� $ 
ExpandPath��$��1,1,1,1q�$
��Left=�$��Center=�"���� 	=     � z  	= � 	=  z 	8��   P�  �@d�	IsChecked$
 TrueY�. ��� $	 
ExpandPath�� � ��" ��     	= � z  	= � 	=  z 	�� " Q�.���  �@Q�
IsExpanded �� *
IsExpanded+$
 TwoWay=���  �@  AcceptsReturn . ��  � ��$ 1q���  � �� �� " Q� ��  lengthConverter $ 19Q�.R��� .+��� $ Bd��# z��#��z��#��z��#��z��._�� ���� 8    �� *TemplatedParent+ �� $��19 ��� .+�d� $ Expander��$ Press=�8��  �� $ 
IsExpanded� �� *TemplatedParent+�� $ PART_Header��$��1��$��Stretch=�$��Stretch=�$��Header���� $ 	ItemsHost�� P�  �@Q�
IsExpanded .  . ��� $	 	ItemsHost�� � y�$ 	Collapsed=�P�  �@��HasItems .  . ��� $	 Expander�� � y�$ Hidden=�]�  ��  � �� .  ��  � ��$
 Auto��./��� $	 PART_Header�� � ��$ 75��]�  ��  � �� .  ��  � ��$
 Auto��./��� $	 PART_Header�� � ��$ 19��P�  �@Q�
IsSelected . . ��� $	 Bd��# � �� � ���� # � �� � ��]�  ��  �@Q�
IsSelected . ��  �@Q�IsSelectionActive .  ./��� $	 Bd��# � �� � ���� # � �� � ��P�  � {� .  . ��� # � �� � ��