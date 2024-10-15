// Decompiled with JetBrains decompiler
// Type: SRPG.StringIsResourcePathPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200114B")]
  public class StringIsResourcePathPopup : PropertyAttribute
  {
    [Token(Token = "0x4003ED9")]
    [FieldOffset(Offset = "0xC")]
    public System.Type ResourceType;
    [Token(Token = "0x4003EDA")]
    [FieldOffset(Offset = "0x10")]
    public string ParentDirectory;

    [Token(Token = "0x60049ED")]
    [Address(RVA = "0x1207F70", Offset = "0x1206D70", VA = "0x11207F70")]
    public StringIsResourcePathPopup(System.Type type)
    {
    }

    [Token(Token = "0x60049EE")]
    [Address(RVA = "0x1207F30", Offset = "0x1206D30", VA = "0x11207F30")]
    public StringIsResourcePathPopup(System.Type type, string dir)
    {
    }
  }
}
