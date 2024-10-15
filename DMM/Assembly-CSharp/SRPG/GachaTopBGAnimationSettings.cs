// Decompiled with JetBrains decompiler
// Type: SRPG.GachaTopBGAnimationSettings
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
  [Token(Token = "0x2002415")]
  public class GachaTopBGAnimationSettings : ScriptableObject
  {
    [Token(Token = "0x400A324")]
    public const string RESOURCE_PATH = "UI/Gacha/GachaTopBGAnimationSettings";
    [Token(Token = "0x400A325")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GachaTopBGAnimationSettings.GachaImageSettings[] GachaImages;
    [Token(Token = "0x400A326")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, GachaTopBGAnimationSettings.GachaImageSettings> GachaImagesDict;

    [Token(Token = "0x6009D1F")]
    [Address(RVA = "0x604680", Offset = "0x603480", VA = "0x10604680")]
    public void InitDict()
    {
    }

    [Token(Token = "0x6009D20")]
    [Address(RVA = "0x6047E0", Offset = "0x6035E0", VA = "0x106047E0")]
    public bool IsAnimation(string key, ref bool is_anim) => new bool();

    [Token(Token = "0x6009D21")]
    [Address(RVA = "0x6049D0", Offset = "0x6037D0", VA = "0x106049D0")]
    public static LoadRequest LoadAsync() => (LoadRequest) null;

    [Token(Token = "0x6009D22")]
    [Address(RVA = "0x604A30", Offset = "0x603830", VA = "0x10604A30")]
    public static GachaTopBGAnimationSettings Load() => (GachaTopBGAnimationSettings) null;

    [Token(Token = "0x6009D23")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public GachaTopBGAnimationSettings()
    {
    }

    [Token(Token = "0x2002416")]
    [Serializable]
    public class GachaImageSettings
    {
      [Token(Token = "0x400A327")]
      [FieldOffset(Offset = "0x8")]
      public string ImageName;
      [Token(Token = "0x400A328")]
      [FieldOffset(Offset = "0xC")]
      public bool IsAnim;

      [Token(Token = "0x6009D24")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public GachaImageSettings()
      {
      }
    }
  }
}
