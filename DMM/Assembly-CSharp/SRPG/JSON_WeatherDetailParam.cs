// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WeatherDetailParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EF1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WeatherDetailParam
  {
    [Token(Token = "0x4008238")]
    [FieldOffset(Offset = "0x8")]
    public string[] buff_ids;
    [Token(Token = "0x4008239")]
    [FieldOffset(Offset = "0xC")]
    public string[] cond_ids;
    [Token(Token = "0x400823A")]
    [FieldOffset(Offset = "0x10")]
    public int fhit;
    [Token(Token = "0x400823B")]
    [FieldOffset(Offset = "0x14")]
    public int fhit_del;
    [Token(Token = "0x400823C")]
    [FieldOffset(Offset = "0x18")]
    public int target;
    [Token(Token = "0x400823D")]
    [FieldOffset(Offset = "0x1C")]
    public int[] atk_types;
    [Token(Token = "0x400823E")]
    [FieldOffset(Offset = "0x20")]
    public int[] atk_dets;
    [Token(Token = "0x400823F")]
    [FieldOffset(Offset = "0x24")]
    public int[] atk_elems;
    [Token(Token = "0x4008240")]
    [FieldOffset(Offset = "0x28")]
    public string[] custom_target_inames;

    [Token(Token = "0x6007E71")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WeatherDetailParam()
    {
    }
  }
}
