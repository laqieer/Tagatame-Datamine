// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002216")]
  public class ConceptCardIconParam : ContentSource.Param
  {
    [Token(Token = "0x40096A0")]
    [FieldOffset(Offset = "0x10")]
    public ConceptCardData ConceptCard;
    [Token(Token = "0x40096A1")]
    [FieldOffset(Offset = "0x14")]
    public bool Select;
    [Token(Token = "0x40096A2")]
    [FieldOffset(Offset = "0x15")]
    public bool Enable;
    [Token(Token = "0x40096A3")]
    [FieldOffset(Offset = "0x16")]
    public bool IsRecommend;
    [Token(Token = "0x40096A4")]
    [FieldOffset(Offset = "0x17")]
    public bool IsEmpty;
    [Token(Token = "0x40096A5")]
    [FieldOffset(Offset = "0x18")]
    public bool IsEnableDecreaseEffect;
    [Token(Token = "0x40096A6")]
    [FieldOffset(Offset = "0x1C")]
    public int DecreaseEffectRate;
    [Token(Token = "0x40096A7")]
    [FieldOffset(Offset = "0x20")]
    private ConceptCardIconNode mNode;

    [Token(Token = "0x60090A0")]
    [Address(RVA = "0x53AD50", Offset = "0x539B50", VA = "0x1053AD50", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x60090A1")]
    [Address(RVA = "0x44CFD0", Offset = "0x44BDD0", VA = "0x1044CFD0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x60090A2")]
    [Address(RVA = "0x53AE10", Offset = "0x539C10", VA = "0x1053AE10")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60090A3")]
    [Address(RVA = "0x53B690", Offset = "0x53A490", VA = "0x1053B690")]
    public ConceptCardIconParam()
    {
    }
  }
}
