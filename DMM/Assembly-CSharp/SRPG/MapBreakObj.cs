// Decompiled with JetBrains decompiler
// Type: SRPG.MapBreakObj
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C3A")]
  [MessagePackObject(true)]
  [Serializable]
  public class MapBreakObj
  {
    [Token(Token = "0x4002015")]
    [FieldOffset(Offset = "0x8")]
    public int clash_type;
    [Token(Token = "0x4002016")]
    [FieldOffset(Offset = "0xC")]
    public int ai_type;
    [Token(Token = "0x4002017")]
    [FieldOffset(Offset = "0x10")]
    public int side_type;
    [Token(Token = "0x4002018")]
    [FieldOffset(Offset = "0x14")]
    public int ray_type;
    [Token(Token = "0x4002019")]
    [FieldOffset(Offset = "0x18")]
    public int is_ui;
    [Token(Token = "0x400201A")]
    [FieldOffset(Offset = "0x1C")]
    public int max_hp;
    [Token(Token = "0x400201B")]
    [FieldOffset(Offset = "0x20")]
    public int[] rest_hps;

    [Token(Token = "0x6003055")]
    [Address(RVA = "0xFE7370", Offset = "0xFE6170", VA = "0x10FE7370")]
    public void CopyTo(MapBreakObj dst)
    {
    }

    [Token(Token = "0x6003056")]
    [Address(RVA = "0xFE7450", Offset = "0xFE6250", VA = "0x10FE7450")]
    public MapBreakObj()
    {
    }
  }
}
