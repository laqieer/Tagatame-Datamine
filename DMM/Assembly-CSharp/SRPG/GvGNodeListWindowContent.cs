// Decompiled with JetBrains decompiler
// Type: SRPG.GvGNodeListWindowContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002601")]
  [AddComponentMenu("UI/GvG/GvGNodeListWindowContent")]
  public class GvGNodeListWindowContent : MonoBehaviour
  {
    [Token(Token = "0x400B0D0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mTitle;
    [Token(Token = "0x400B0D1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject MapParent;
    [Token(Token = "0x400B0D2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject PrepareStatus;
    [Token(Token = "0x400B0D3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject OffenseStatus;
    [Token(Token = "0x400B0D4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject DefenseStatus;
    [Token(Token = "0x400B0D5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject DeclaredStatus;
    [Token(Token = "0x400B0D6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mTitleType;
    [Token(Token = "0x400B0D7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ImageArray mDefensePartyIcon;
    [Token(Token = "0x400B0D8")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject CoolTimeStatus;
    [Token(Token = "0x400B0D9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mCoolTimeText;
    [Token(Token = "0x400B0DA")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Button mDetailButton;
    [Token(Token = "0x400B0DB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button mDefenseButton;
    [Token(Token = "0x400B0DC")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button mConfirmButton;
    [Token(Token = "0x400B0DD")]
    [FieldOffset(Offset = "0x40")]
    private GvGNodeData mGvGNodeData;
    [Token(Token = "0x400B0DE")]
    [FieldOffset(Offset = "0x44")]
    private float mCoolTimeCount;

    [Token(Token = "0x600A94F")]
    [Address(RVA = "0x6C6740", Offset = "0x6C5540", VA = "0x106C6740")]
    private void Update()
    {
    }

    [Token(Token = "0x600A950")]
    [Address(RVA = "0x6C6050", Offset = "0x6C4E50", VA = "0x106C6050")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600A951")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGNodeListWindowContent()
    {
    }
  }
}
