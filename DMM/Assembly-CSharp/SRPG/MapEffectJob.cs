// Decompiled with JetBrains decompiler
// Type: SRPG.MapEffectJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200270A")]
  [AddComponentMenu("UI/MapEffect/MapEffectJob")]
  public class MapEffectJob : MonoBehaviour
  {
    [Token(Token = "0x400B806")]
    [FieldOffset(Offset = "0xC")]
    public GameObject GoMapEffectParent;
    [Token(Token = "0x400B807")]
    [FieldOffset(Offset = "0x10")]
    public GameObject GoMapEffectBaseItem;

    [Token(Token = "0x600AF07")]
    [Address(RVA = "0x7344F0", Offset = "0x7332F0", VA = "0x107344F0")]
    public void Setup()
    {
    }

    [Token(Token = "0x600AF08")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MapEffectJob()
    {
    }

    [Token(Token = "0x200270B")]
    private class MeSkill
    {
      [Token(Token = "0x400B808")]
      [FieldOffset(Offset = "0x8")]
      public MapEffectParam mMapEffectParam;
      [Token(Token = "0x400B809")]
      [FieldOffset(Offset = "0xC")]
      public SkillParam mSkillParam;

      [Token(Token = "0x600AF09")]
      [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
      public MeSkill(MapEffectParam me_param, SkillParam skill_param)
      {
      }

      [Token(Token = "0x600AF0A")]
      [Address(RVA = "0x738B80", Offset = "0x737980", VA = "0x10738B80")]
      public bool Equals(MapEffectParam me_param, SkillParam skill_param) => new bool();
    }
  }
}
