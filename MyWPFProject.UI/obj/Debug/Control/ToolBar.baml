   M S B A M L   `   `   `  ����J  FMyWPFProject.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MyWPFProject.UIMyWPFProject.UI  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5          MyWPFProject.UI.ToolBar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MyWPFProject.UI     5      6sys&clr-namespace:System;assembly=mscorlib     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      V RGalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=null*cmd http://www.galasoft.ch/mvvmlight  5	      -   5        $��	UCToolBar��5      $��50��5      $
��auto��5        � 	Resources  5      /   )MyWPFProject.UI.BoolToVisibilityConverter   BoolToVisibility)   #MyWPFProject.UI.EnumToBoolConverter  
EnumToBool��%:   &	        &	        5   
   6*     5   
   6$   5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      /  )GalaSoft.MvvmLight.Command.EventToCommand     Command 6!   �� *	CmdLoaded+   CommandParameter 6?   ��  �� ElementName$ 	UCToolBar��5        5   
   $ 	MouseMove��6   . 5           PassEventArgsToCommand .  6!   �� *CmdMouseMove+6B   5        5   
   $ 	MouseDown��6   . 5         .  6!   �� *CmdMouseDown+6B   5      .��5       ��  �� Orientation$ 
Horizontal=�6   $��3 0 3 0q�6*   ��6;   �� 	 �� Path$	 ActualWidth�$ 	UCToolBar����6u   �� $	 ActualHeight�$ 	UCToolBar��.+�5!   
   �� $��	文本框��6   $
��auto��6   $��0 3 0 0q�6,   $��Center=�6=   �� 5"   
   $��80��62   $��Center=�6@   $��3 0 0 0q�6[   ��6   �� *TextBoxContent+6[   �� 5#   
   $��	数字框��6   $
��auto��6   $��3 3 0 0q�6,   $��Center=�6=   �� 5$   
   -   5        $��	TextValue��5$      $��80��6B   $��Center=�6P   $��3 0 0 0q�6k   
 �� IsInputMethodEnabled
 .  ��6#   �� *TextBoxNumber+.��5%   ;   .��5&   ,    J� CommandBindings 5'      )  #System.Windows.Input.CommandBinding  5(      -   5           Command$ ApplicationCommands.Paste��5(   !   6n     5)      -   5        $ ApplicationCommands.Cut��5)   !   6l     5*      -   5        $ ApplicationCommands.Copy��5*   !   6m   .��5+   '    5,        5-      $ KeyDown��6!   . 5.         .  6)   �� *
CmdKeyDown+6H   5/      .��50   &   51      �� 52   
   $��	下拉框��6   $
��auto��6   $��3 3 0 0q�6,   $��Center=�6=   �� 53   
    �� DisplayMemberPath$
 Name��6<    �� SelectedValuePath$ Value��6U   $��3 0 0 0q�6�   $��Center=�6�   $��80��6�   ��6   �� *DataTypeSources+ �� SelectedValue 6o   �� *SelectedDataType+ 54        55      $ SelectionChanged��6!   . 56         .  6)   �� *CmdSelectionChanged+6Q   57      59      �� 5:   
   $��Radio��6   $��Center=�6!   $
��auto��6<   $��3 3 0 0q�6I   	� 5;   
   $	��是��6   $��3 3 0 0q�6�   $��Center=�6�    d� 	IsChecked 6"   �� *SelectTypeEnum+ �� Mode$ TwoWay=� �� 	Converter# [  �� ConverterParameter$ 1��6�   	� 5<   
   $	��否��6   $��3 3 0 0q�6�   $��Center=�6�    6"   �� *SelectTypeEnum+$ TwoWay=�# [ $ 2��6�   �� 5=   
   $��	选择框��6   $
��auto��6   $��3 3 0 0q�6,   $��Center=�6=   �� 5>   
   -   5        $��CheckBoxControl��5>      $
 TrueY�6*   $��Center=�6;   $��3 0 0 0q�6V   �� 5?   
   $��选中��6   $��3 3 0 0q�6   $��Center=�6/   y�6J   �� $ CheckBoxControl��$	 	IsChecked�# [  �� 5@   
   $��+��6   $��3 3 0 0q�6   $��Center=�6.    5A        5B      $ Click��6!   . 5C         . $	 111��6k    6)   �� *CmdButtonClick1+6k   5D      5F      �� 5G   
   $��-��6   $��3 3 0 0q�6   $��-��6P   $��Center=�6e   ��6.   �� *CmdBtnCommand+6e   �� 5H   
   $��鼠标位置��6   $
��auto��6    $��3 3 0 0q�6-   $��Center=�6>   �� 5I   
   $��Center=�6/   $��3 3 0 0q�6J   ��6   �� *	MouseText+6J   �� 5J   
   $��鼠标点击��6   $
��auto��6    $��3 3 0 0q�6-   $��Center=�6>   �� 5K   
   $��Center=�64   $��3 3 0 0q�6O   ��6   �� *MouseClickText+6O   5L      5Q      