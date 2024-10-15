// Decompiled with JetBrains decompiler
// Type: SRPG.UnitImageSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E9A")]
  [Serializable]
  public class UnitImageSetting
  {
    [Token(Token = "0x4002CDC")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    private System.Collections.Generic.List<UnitImageSetting.KeyValue> List;
    [Token(Token = "0x4002CDD")]
    [FieldOffset(Offset = "0xC")]
    private Dictionary<string, UnitImageSetting.Vector2AndFloat> mTable;

    [Token(Token = "0x6003CC9")]
    [Address(RVA = "0x1105D80", Offset = "0x1104B80", VA = "0x11105D80")]
    public Dictionary<string, UnitImageSetting.Vector2AndFloat> GetTable()
    {
      return (Dictionary<string, UnitImageSetting.Vector2AndFloat>) null;
    }

    [Token(Token = "0x6003CCA")]
    [Address(RVA = "0x1105BE0", Offset = "0x11049E0", VA = "0x11105BE0")]
    private Dictionary<string, UnitImageSetting.Vector2AndFloat> ConvertListToDictionary(
      System.Collections.Generic.List<UnitImageSetting.KeyValue> list)
    {
      return (Dictionary<string, UnitImageSetting.Vector2AndFloat>) null;
    }

    [Token(Token = "0x6003CCB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitImageSetting()
    {
    }

    [Token(Token = "0x2000E9B")]
    [Serializable]
    public class KeyValue
    {
      [Token(Token = "0x4002CDE")]
      [FieldOffset(Offset = "0x8")]
      public string Key;
      [Token(Token = "0x4002CDF")]
      [FieldOffset(Offset = "0xC")]
      public UnitImageSetting.Vector2AndFloat Value;

      [Token(Token = "0x6003CCC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public KeyValue()
      {
      }
    }

    [Token(Token = "0x2000E9C")]
    [Serializable]
    public class Vector2AndFloat
    {
      [Token(Token = "0x4002CE0")]
      [FieldOffset(Offset = "0x8")]
      public Vector2 Offset;
      [Token(Token = "0x4002CE1")]
      [FieldOffset(Offset = "0x10")]
      public float Scale;

      [Token(Token = "0x6003CCD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Vector2AndFloat()
      {
      }
    }
  }
}
