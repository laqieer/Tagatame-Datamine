// Decompiled with JetBrains decompiler
// Type: SRPG.UnitGetDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C2A")]
  [AddComponentMenu("UI/UnitGetDetail")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  public class UnitGetDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DA90")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mRenkeiText;
    [Token(Token = "0x400DA91")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mMoveText;
    [Token(Token = "0x400DA92")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mJumpText;
    [Token(Token = "0x400DA93")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mLeaderSkillText;
    [Token(Token = "0x400DA94")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button mLeaderSkillDetailButton;
    [Token(Token = "0x400DA95")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject Prefab_LeaderSkillDetail;
    [Token(Token = "0x400DA96")]
    [FieldOffset(Offset = "0x24")]
    private GameObject mLeaderSkillDetail;
    [Token(Token = "0x400DA97")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    internal string UnitName;
    [Token(Token = "0x400DA98")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject[] mJobRoot;
    [Token(Token = "0x400DA99")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mAbilityTemplate;
    [Token(Token = "0x400DA9A")]
    [FieldOffset(Offset = "0x34")]
    private Transform mPreviewParent;
    [Token(Token = "0x400DA9B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string mPreviewParentID;
    [Token(Token = "0x400DA9C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private string mPreviewBaseID;
    [Token(Token = "0x400DA9D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RawImage mBGUnitImage;
    [Token(Token = "0x400DA9E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private RawImage mBGUnitMaskImage;
    [Token(Token = "0x400DA9F")]
    [FieldOffset(Offset = "0x48")]
    private float mBGUnitImgAlphaStart;
    [Token(Token = "0x400DAA0")]
    [FieldOffset(Offset = "0x4C")]
    private float mBGUnitImgAlphaEnd;
    [Token(Token = "0x400DAA1")]
    [FieldOffset(Offset = "0x50")]
    private float mBGUnitImgFadeTime;
    [Token(Token = "0x400DAA2")]
    [FieldOffset(Offset = "0x54")]
    private float mBGUnitImgFadeTimeMax;
    [Token(Token = "0x400DAA3")]
    [FieldOffset(Offset = "0x58")]
    private UnitPreview mCurrentPreview;
    [Token(Token = "0x400DAA4")]
    [FieldOffset(Offset = "0x5C")]
    private List<UnitPreview> mPreviewControllers;
    [Token(Token = "0x400DAA5")]
    [FieldOffset(Offset = "0x60")]
    private List<GameObject> mAbilits;

    [Token(Token = "0x600CC7E")]
    [Address(RVA = "0x974AA0", Offset = "0x9738A0", VA = "0x10974AA0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600CC7F")]
    [Address(RVA = "0x974A30", Offset = "0x973830", VA = "0x10974A30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CC80")]
    [Address(RVA = "0x975A60", Offset = "0x974860", VA = "0x10975A60")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600CC81")]
    [Address(RVA = "0x975090", Offset = "0x973E90", VA = "0x10975090")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600CC82")]
    [Address(RVA = "0x976560", Offset = "0x975360", VA = "0x10976560")]
    private void Update()
    {
    }

    [Token(Token = "0x600CC83")]
    [Address(RVA = "0x974ED0", Offset = "0x973CD0", VA = "0x10974ED0")]
    internal void DummyBind()
    {
    }

    [Token(Token = "0x600CC84")]
    [Address(RVA = "0x976130", Offset = "0x974F30", VA = "0x10976130")]
    internal void UpdateUI()
    {
    }

    [Token(Token = "0x600CC85")]
    [Address(RVA = "0x9751E0", Offset = "0x973FE0", VA = "0x109751E0")]
    private void OpenLeaderSkillDetail()
    {
    }

    [Token(Token = "0x600CC86")]
    [Address(RVA = "0x9752E0", Offset = "0x9740E0", VA = "0x109752E0")]
    private void RefreshAbilitList()
    {
    }

    [Token(Token = "0x600CC87")]
    [Address(RVA = "0x9758C0", Offset = "0x9746C0", VA = "0x109758C0")]
    private void RefreshLeaderSkillInfo()
    {
    }

    [Token(Token = "0x600CC88")]
    [Address(RVA = "0x975AD0", Offset = "0x9748D0", VA = "0x10975AD0")]
    private void ReloadPreviewModels()
    {
    }

    [Token(Token = "0x600CC89")]
    [Address(RVA = "0x974BA0", Offset = "0x9739A0", VA = "0x10974BA0")]
    private UnitData CreateUnitData(UnitParam uparam) => (UnitData) null;

    [Token(Token = "0x600CC8A")]
    [Address(RVA = "0x975040", Offset = "0x973E40", VA = "0x10975040")]
    private void FadeUnitImage(float alphastart, float alphaend, float duration)
    {
    }

    [Token(Token = "0x600CC8B")]
    [Address(RVA = "0x975F80", Offset = "0x974D80", VA = "0x10975F80")]
    private void SetUnitImageAlpha(float alpha)
    {
    }

    [Token(Token = "0x600CC8C")]
    [Address(RVA = "0x9760C0", Offset = "0x974EC0", VA = "0x109760C0")]
    private IEnumerator UpdateFadeUnitImage() => (IEnumerator) null;

    [Token(Token = "0x600CC8D")]
    [Address(RVA = "0x9759F0", Offset = "0x9747F0", VA = "0x109759F0")]
    private IEnumerator RefreshUnitImage() => (IEnumerator) null;

    [Token(Token = "0x600CC8E")]
    [Address(RVA = "0x976670", Offset = "0x975470", VA = "0x10976670")]
    public UnitGetDetail()
    {
    }
  }
}
