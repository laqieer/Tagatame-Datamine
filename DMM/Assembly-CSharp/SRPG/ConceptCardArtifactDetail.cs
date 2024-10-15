// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardArtifactDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021D3")]
  [AddComponentMenu("UI/ConceptCardArtifactDetail")]
  public class ConceptCardArtifactDetail : MonoBehaviour
  {
    [Token(Token = "0x4009474")]
    [FieldOffset(Offset = "0xC")]
    private ArtifactData UnlockArtifact;
    [Token(Token = "0x4009475")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private StatusList mArtifactStatus;
    [Token(Token = "0x4009476")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mAbilityListItem;
    [Token(Token = "0x4009477")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Animator mAbilityAnimator;
    [Token(Token = "0x4009478")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string mAbilityListItemState;
    [Token(Token = "0x4009479")]
    [FieldOffset(Offset = "0x20")]
    public GameObject DetailWindow;
    [Token(Token = "0x400947A")]
    [FieldOffset(Offset = "0x24")]
    private GameObject mDetailWindow;

    [Token(Token = "0x6008ED1")]
    [Address(RVA = "0x520EA0", Offset = "0x51FCA0", VA = "0x10520EA0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008ED2")]
    [Address(RVA = "0x5207C0", Offset = "0x51F5C0", VA = "0x105207C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008ED3")]
    [Address(RVA = "0x520CD0", Offset = "0x51FAD0", VA = "0x10520CD0")]
    public void SetArtifactData()
    {
    }

    [Token(Token = "0x6008ED4")]
    [Address(RVA = "0x520DE0", Offset = "0x51FBE0", VA = "0x10520DE0")]
    public void ShowDetail()
    {
    }

    [Token(Token = "0x6008ED5")]
    [Address(RVA = "0x520D70", Offset = "0x51FB70", VA = "0x10520D70")]
    private IEnumerator ShowDetailAsync() => (IEnumerator) null;

    [Token(Token = "0x6008ED6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardArtifactDetail()
    {
    }

    [Token(Token = "0x20021D4")]
    private enum AbilityAnimatorType
    {
      [Token(Token = "0x400947C")] Hidden,
      [Token(Token = "0x400947D")] Locked,
      [Token(Token = "0x400947E")] Unlocked,
    }
  }
}
