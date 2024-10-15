// Decompiled with JetBrains decompiler
// Type: SRPG.MapEffectQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200270D")]
  [AddComponentMenu("UI/MapEffect/MapEffectQuest")]
  public class MapEffectQuest : MonoBehaviour
  {
    [Token(Token = "0x400B80C")]
    [FieldOffset(Offset = "0xC")]
    public GameObject GoMapEffectParent;
    [Token(Token = "0x400B80D")]
    [FieldOffset(Offset = "0x10")]
    public GameObject GoMapEffectBaseItem;

    [Token(Token = "0x600AF0E")]
    [Address(RVA = "0x735210", Offset = "0x734010", VA = "0x10735210")]
    public void Setup()
    {
    }

    [Token(Token = "0x600AF0F")]
    [Address(RVA = "0x734F90", Offset = "0x733D90", VA = "0x10734F90")]
    public static GameObject CreateInstance(GameObject go_target, Transform parent = null)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600AF10")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MapEffectQuest()
    {
    }
  }
}
