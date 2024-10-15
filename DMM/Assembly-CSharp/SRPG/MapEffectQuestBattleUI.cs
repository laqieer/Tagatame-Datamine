// Decompiled with JetBrains decompiler
// Type: SRPG.MapEffectQuestBattleUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200270E")]
  [AddComponentMenu("UI/MapEffect/MapEffectQuestBattleUI")]
  public class MapEffectQuestBattleUI : MonoBehaviour
  {
    [Token(Token = "0x400B80E")]
    [FieldOffset(Offset = "0xC")]
    public SRPG_Button ButtonMapEffect;
    [Token(Token = "0x400B80F")]
    [FieldOffset(Offset = "0x10")]
    [StringIsResourcePath(typeof (GameObject))]
    public string PrefabMapEffectQuest;
    [Token(Token = "0x400B810")]
    [FieldOffset(Offset = "0x14")]
    private LoadRequest mReqMapEffect;

    [Token(Token = "0x600AF11")]
    [Address(RVA = "0x734EE0", Offset = "0x733CE0", VA = "0x10734EE0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AF12")]
    [Address(RVA = "0x734E70", Offset = "0x733C70", VA = "0x10734E70")]
    private void ReqOpenMapEffect()
    {
    }

    [Token(Token = "0x600AF13")]
    [Address(RVA = "0x734E00", Offset = "0x733C00", VA = "0x10734E00")]
    private IEnumerator OpenMapEffect() => (IEnumerator) null;

    [Token(Token = "0x600AF14")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MapEffectQuestBattleUI()
    {
    }
  }
}
