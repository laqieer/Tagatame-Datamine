// Decompiled with JetBrains decompiler
// Type: SRPG.VersusFriendMatchDraft
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002746")]
  [AddComponentMenu("UI/Multi/Versus/Draft/VersusFriendMatchDraft")]
  public class VersusFriendMatchDraft : MonoBehaviour
  {
    [Token(Token = "0x400B951")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mPulldownSelectIconGO;
    [Token(Token = "0x400B952")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Pulldown mPulldown;
    [Token(Token = "0x400B953")]
    [FieldOffset(Offset = "0x14")]
    private List<ToggledPulldownItem> mItems;

    [Token(Token = "0x600B020")]
    [Address(RVA = "0x74FB40", Offset = "0x74E940", VA = "0x1074FB40")]
    private void Start()
    {
    }

    [Token(Token = "0x600B021")]
    [Address(RVA = "0x74FA10", Offset = "0x74E810", VA = "0x1074FA10")]
    private void SelectDeck(int deck_id)
    {
    }

    [Token(Token = "0x600B022")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusFriendMatchDraft()
    {
    }
  }
}
