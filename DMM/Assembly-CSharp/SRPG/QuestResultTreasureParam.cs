// Decompiled with JetBrains decompiler
// Type: SRPG.QuestResultTreasureParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028C3")]
  public class QuestResultTreasureParam : ContentSource.Param
  {
    [Token(Token = "0x400C362")]
    [FieldOffset(Offset = "0x10")]
    public QuestResult.DropItemData ItemData;
    [Token(Token = "0x400C363")]
    [FieldOffset(Offset = "0x14")]
    public ArtifactParam ArtfactParam;
    [Token(Token = "0x400C364")]
    [FieldOffset(Offset = "0x18")]
    public int ArtfactNum;
    [Token(Token = "0x400C365")]
    [FieldOffset(Offset = "0x1C")]
    public int GoldNum;
    [Token(Token = "0x400C366")]
    [FieldOffset(Offset = "0x20")]
    public Texture2D GoldTex;
    [Token(Token = "0x400C367")]
    [FieldOffset(Offset = "0x24")]
    public Sprite GoldFrame;
    [Token(Token = "0x400C368")]
    [FieldOffset(Offset = "0x28")]
    public GameObject mSelectObj;
    [Token(Token = "0x400C369")]
    [FieldOffset(Offset = "0x2C")]
    public bool IsEndAnim;
    [Token(Token = "0x400C36A")]
    [FieldOffset(Offset = "0x30")]
    private QuestResultTreasureNode mNode;

    [Token(Token = "0x600B845")]
    [Address(RVA = "0x7F38C0", Offset = "0x7F26C0", VA = "0x107F38C0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600B846")]
    [Address(RVA = "0x7F3890", Offset = "0x7F2690", VA = "0x107F3890", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600B847")]
    [Address(RVA = "0x7F39D0", Offset = "0x7F27D0", VA = "0x107F39D0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B848")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public QuestResultTreasureParam()
    {
    }
  }
}
