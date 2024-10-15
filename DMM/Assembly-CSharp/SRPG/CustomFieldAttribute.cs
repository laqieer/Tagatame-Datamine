// Decompiled with JetBrains decompiler
// Type: SRPG.CustomFieldAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E69")]
  public class CustomFieldAttribute : Attribute
  {
    [Token(Token = "0x6003BB4")]
    [Address(RVA = "0x10F04C0", Offset = "0x10EF2C0", VA = "0x110F04C0")]
    public CustomFieldAttribute(string _text, CustomFieldAttribute.Type _type)
    {
    }

    [Token(Token = "0x6003BB5")]
    [Address(RVA = "0x10F04C0", Offset = "0x10EF2C0", VA = "0x110F04C0")]
    public CustomFieldAttribute(
      string _text,
      CustomFieldAttribute.Type _type,
      System.Type _sysType = null,
      System.Type _tblType = null)
    {
    }

    [Token(Token = "0x2000E6A")]
    public enum Type
    {
      [Token(Token = "0x4002BEB")] MonoBehaviour,
      [Token(Token = "0x4002BEC")] GameObject,
      [Token(Token = "0x4002BED")] UIText,
      [Token(Token = "0x4002BEE")] UIRawImage,
      [Token(Token = "0x4002BEF")] UIImage,
      [Token(Token = "0x4002BF0")] UISprite,
      [Token(Token = "0x4002BF1")] UIButton,
      [Token(Token = "0x4002BF2")] UISlider,
      [Token(Token = "0x4002BF3")] UISpriteSheet,
      [Token(Token = "0x4002BF4")] EnumString,
      [Token(Token = "0x4002BF5")] ImageArray,
      [Token(Token = "0x4002BF6")] Enum,
      [Token(Token = "0x4002BF7")] Component,
      [Token(Token = "0x4002BF8")] UIToggle,
      [Token(Token = "0x4002BF9")] Array,
      [Token(Token = "0x4002BFA")] Material,
    }

    [Token(Token = "0x2000E6B")]
    public class Element
    {
      [Token(Token = "0x4002BFB")]
      [FieldOffset(Offset = "0x8")]
      public object type;
      [Token(Token = "0x4002BFC")]
      [FieldOffset(Offset = "0xC")]
      public string desc;

      [Token(Token = "0x6003BB6")]
      [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
      public Element(object _type, string _desc)
      {
      }
    }
  }
}
