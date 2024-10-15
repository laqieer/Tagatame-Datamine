// Decompiled with JetBrains decompiler
// Type: SRPG.GvGNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025F7")]
  [AddComponentMenu("UI/GvG/GvGNode")]
  public class GvGNode : MonoBehaviour
  {
    [Token(Token = "0x400B07B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mOffenseGuild;
    [Token(Token = "0x400B07C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mDefenseGuild;
    [Token(Token = "0x400B07D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Image mOffenseGuildImage;
    [Token(Token = "0x400B07E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image mDefenseGuildImage;
    [Token(Token = "0x400B07F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mNodeName;
    [Token(Token = "0x400B080")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mCoolTime;
    [Token(Token = "0x400B081")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mCoolTimeText;
    [Token(Token = "0x400B082")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ImageArray mDefensePartyIcon;
    [Token(Token = "0x400B083")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mPrepare;
    [Token(Token = "0x400B084")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mPrepareAnimON;
    [Token(Token = "0x400B085")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mPrepareAnimOFF;
    [Token(Token = "0x400B086")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mBattle;
    [Token(Token = "0x400B087")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mBattleAnimON;
    [Token(Token = "0x400B088")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mBattleAnimOFF;
    [Token(Token = "0x400B089")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mDefense;
    [Token(Token = "0x400B08A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mDefenseAnimON;
    [Token(Token = "0x400B08B")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mDefenseAnimOFF;
    [Token(Token = "0x400B08C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ChangeMaterialList mChangeColorList;
    [Token(Token = "0x400B08D")]
    [FieldOffset(Offset = "0x54")]
    private GvGNodeData mGvGNodeData;
    [Token(Token = "0x400B08E")]
    [FieldOffset(Offset = "0x58")]
    private float mCoolTimeCount;

    [Token(Token = "0x600A911")]
    [Address(RVA = "0x6C18C0", Offset = "0x6C06C0", VA = "0x106C18C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600A912")]
    [Address(RVA = "0x6C0F30", Offset = "0x6BFD30", VA = "0x106C0F30")]
    public void Refresh(GvGNodeData data)
    {
    }

    [Token(Token = "0x600A913")]
    [Address(RVA = "0x6C1480", Offset = "0x6C0280", VA = "0x106C1480")]
    private void SetImageMaterial(Image image, Material mat)
    {
    }

    [Token(Token = "0x600A914")]
    [Address(RVA = "0x6C1510", Offset = "0x6C0310", VA = "0x106C1510")]
    private void SetNodeStatus(GvGNodeState state)
    {
    }

    [Token(Token = "0x600A915")]
    [Address(RVA = "0x6C0E10", Offset = "0x6BFC10", VA = "0x106C0E10")]
    public void OnSelectNode()
    {
    }

    [Token(Token = "0x600A916")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGNode()
    {
    }
  }
}
