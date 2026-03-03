//Opisywacz

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace nuggets
{
    public partial class ViewModelOpisywacz : ObservableObject
    {
        [ObservableProperty]
        private string author = "Jakub Jabłoński";
        [ObservableProperty]
        private string cecha1;
        [ObservableProperty]
        private string cecha2;
        [ObservableProperty]
        private string cecha3;
        [ObservableProperty]
        private DateOnly data;

        [RelayCommand]
        private void WypiszCechy()
        {
            
        }
    }
}

//XAML
<Window x:Class="nuggets.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:nuggets"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="4*"/>
            <RowDefinition Height="5*"/>
            <RowDefinition Height="3*"/>
        </Grid.RowDefinitions>
        
        <StackPanel Grid.Row="0" Orientation="Vertical">
            <StackPanel>
                <StackPanel Height="Auto">
                    <TextBlock Text="Autor: " FontSize="24" TextAlignment="Center"/>
                </StackPanel>
                <StackPanel Height="Auto" Orientation="Horizontal">
                    <TextBox Width="300" Height="20" Margin="50 0 100 0"></TextBox>
                    <Button Width="100" Height="40" Content="Dodaj"></Button>
                </StackPanel>
            </StackPanel>
        </StackPanel>
        <StackPanel Grid.Row="1" Orientation="Vertical">
            <StackPanel Orientation="Horizontal">
                <Label Content="C1 - "></Label>
                <TextBlock Width="500" Name="C1"></TextBlock>
                <Button Width="100" Margin="20 0 0 0"></Button>
                <Button Width="100" Margin="20 0 0 0"></Button>
            </StackPanel>
            <StackPanel Orientation="Horizontal" Margin="0 30 0 0">
                <Label Content="C2 - "></Label>
                <TextBlock Width="500" Name="C2"></TextBlock>
                <Button Width="100" Margin="20 0 0 0"></Button>
                <Button Width="100" Margin="20 0 0 0"></Button>
            </StackPanel>
            <StackPanel Orientation="Horizontal"  Margin="0 30 0 0">
                <Label Content="C3 - "></Label>
                <TextBlock Width="500" Name="C3"></TextBlock>
                <Button Width="100" Margin="20 0 0 0"></Button>
                <Button Width="100" Margin="20 0 0 0"></Button>
            </StackPanel>
        </StackPanel>
        <StackPanel Grid.Row="2" Orientation="Vertical">
            <TextBlock Text="Opis:"/>
            <TextBlock Height="80"></TextBlock>
        </StackPanel>
    </Grid>
</Window>

