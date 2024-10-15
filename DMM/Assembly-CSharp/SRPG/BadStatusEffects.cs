// Decompiled with JetBrains decompiler
// Type: SRPG.BadStatusEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E6C")]
  public static class BadStatusEffects
  {
    [Token(Token = "0x4002BFD")]
    private const string BAD_STATUS_FILE_PATH = "Data/badstatus";
    [Token(Token = "0x4002BFE")]
    [FieldOffset(Offset = "0x0")]
    public static List<BadStatusEffects.Desc> Effects;
    [Token(Token = "0x4002BFF")]
    [FieldOffset(Offset = "0x4")]
    public static GameObject CurseEffect;
    [Token(Token = "0x4002C00")]
    [FieldOffset(Offset = "0x8")]
    public static string CurseEffectAttachTarget;
    [Token(Token = "0x4002C01")]
    [FieldOffset(Offset = "0xC")]
    public static string CurseEffectAttachTargetBigUnit;

    [Token(Token = "0x6003BB7")]
    [Address(RVA = "0x10E1CC0", Offset = "0x10E0AC0", VA = "0x110E1CC0")]
    public static BadStatusEffects.BadStatusEffectParam LoadBadStatusEffectParam()
    {
      return (BadStatusEffects.BadStatusEffectParam) null;
    }

    [Token(Token = "0x6003BB8")]
    [Address(RVA = "0x10E1EB0", Offset = "0x10E0CB0", VA = "0x110E1EB0")]
    public static IEnumerator LoadQuestAssetEffects() => (IEnumerator) null;

    [Token(Token = "0x6003BB9")]
    [Address(RVA = "0x10E1E40", Offset = "0x10E0C40", VA = "0x110E1E40")]
    public static IEnumerator LoadEffects(QuestAssets assets) => (IEnumerator) null;

    [Token(Token = "0x6003BBA")]
    [Address(RVA = "0x10E1DF0", Offset = "0x10E0BF0", VA = "0x110E1DF0")]
    public static IEnumerator LoadBigUnitEffects() => (IEnumerator) null;

    [Token(Token = "0x6003BBB")]
    [Address(RVA = "0x10E1F00", Offset = "0x10E0D00", VA = "0x110E1F00")]
    public static void UnloadEffects()
    {
    }

    [Token(Token = "0x6003BBC")]
    [Address(RVA = "0x10E1C60", Offset = "0x10E0A60", VA = "0x110E1C60")]
    public static bool IsLoaded() => new bool();

    [Token(Token = "0x2000E6D")]
    public class Desc
    {
      [Token(Token = "0x4002C02")]
      [FieldOffset(Offset = "0x8")]
      public EUnitCondition Key;
      [Token(Token = "0x4002C03")]
      [FieldOffset(Offset = "0x10")]
      public GameObject Effect;
      [Token(Token = "0x4002C04")]
      [FieldOffset(Offset = "0x14")]
      public string NameEffectBigUnit;
      [Token(Token = "0x4002C05")]
      [FieldOffset(Offset = "0x18")]
      public GameObject EffectBigUnit;
      [Token(Token = "0x4002C06")]
      [FieldOffset(Offset = "0x1C")]
      public string AttachTarget;
      [Token(Token = "0x4002C07")]
      [FieldOffset(Offset = "0x20")]
      public string AttachTargetBigUnit;
      [Token(Token = "0x4002C08")]
      [FieldOffset(Offset = "0x24")]
      public Color BlendColor;
      [Token(Token = "0x4002C09")]
      [FieldOffset(Offset = "0x34")]
      public string AnimationName;
      [Token(Token = "0x4002C0A")]
      [FieldOffset(Offset = "0x38")]
      public string NameEffect;

      [Token(Token = "0x17000471")]
      public string EffectPath
      {
        [Token(Token = "0x6003BBD"), Address(RVA = "0x10F0520", Offset = "0x10EF320", VA = "0x110F0520")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000472")]
      public string EffectBigUnitPath
      {
        [Token(Token = "0x6003BBE"), Address(RVA = "0x10F04E0", Offset = "0x10EF2E0", VA = "0x110F04E0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6003BBF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Desc()
      {
      }
    }

    [Token(Token = "0x2000E6E")]
    public class BadStatusEffectParam
    {
      [Token(Token = "0x4002C0B")]
      [FieldOffset(Offset = "0x8")]
      public int colID;
      [Token(Token = "0x4002C0C")]
      [FieldOffset(Offset = "0xC")]
      public int colColor;
      [Token(Token = "0x4002C0D")]
      [FieldOffset(Offset = "0x10")]
      public int colAnimation;
      [Token(Token = "0x4002C0E")]
      [FieldOffset(Offset = "0x14")]
      public int colEffect;
      [Token(Token = "0x4002C0F")]
      [FieldOffset(Offset = "0x18")]
      public int colAttachTarget;
      [Token(Token = "0x4002C10")]
      [FieldOffset(Offset = "0x1C")]
      public int colAttachTargetBigUnit;
      [Token(Token = "0x4002C11")]
      [FieldOffset(Offset = "0x20")]
      public int colEffectBigUnit;
      [Token(Token = "0x4002C12")]
      [FieldOffset(Offset = "0x24")]
      public List<BadStatusEffects.Desc> effects;

      [Token(Token = "0x6003BC0")]
      [Address(RVA = "0x10E1610", Offset = "0x10E0410", VA = "0x110E1610")]
      public bool Load() => new bool();

      [Token(Token = "0x6003BC1")]
      [Address(RVA = "0x10E1710", Offset = "0x10E0510", VA = "0x110E1710")]
      private void Parse(string value)
      {
      }

      [Token(Token = "0x6003BC2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BadStatusEffectParam()
      {
      }
    }
  }
}
