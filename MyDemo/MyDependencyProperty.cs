using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyDemo
{
    public class MyDependencyProperty:UserControl
    {
        //3、使用.NET属性包装依赖属性:属性名称与注册时候的名称必须一致，
        //即属性名MyColorProperty对应注册时的MyColorProperty

        public string MyColorProperty
        {
            get { return (string)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyColorProperty", 
                typeof(string),//依赖属性的类型
                typeof(MyDependencyProperty),//给哪个类注册依赖属性
                new PropertyMetadata("red",(s,e)=>
                {
                    var mdp = s as MyDependencyProperty;
                    if (s != null)
                    {
                        try
                        {
                            var color = (Color)ColorConverter.ConvertFromString(e.NewValue.ToString());
                            mdp.Foreground = new SolidColorBrush(color);
                        }
                        catch (Exception)
                        {
                            mdp.Foreground = new SolidColorBrush(Colors.Black);
                        }
                    }
                })//初始值
                );


    }
}
