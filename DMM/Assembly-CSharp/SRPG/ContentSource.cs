// Decompiled with JetBrains decompiler
// Type: SRPG.ContentSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200225C")]
  public class ContentSource
  {
    [Token(Token = "0x40098BB")]
    [FieldOffset(Offset = "0x8")]
    private ContentSource.Param[] m_Table;
    [Token(Token = "0x40098BC")]
    [FieldOffset(Offset = "0xC")]
    private ContentController m_ContentController;

    [Token(Token = "0x170014A1")]
    protected ContentController contentController
    {
      [Token(Token = "0x60092D6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ContentController) null;
      }
    }

    [Token(Token = "0x60092D7")]
    [Address(RVA = "0x563580", Offset = "0x562380", VA = "0x10563580", Slot = "4")]
    public virtual void Initialize(ContentController controller)
    {
    }

    [Token(Token = "0x60092D8")]
    [Address(RVA = "0x563690", Offset = "0x562490", VA = "0x10563690", Slot = "5")]
    public virtual void Release()
    {
    }

    [Token(Token = "0x60092D9")]
    [Address(RVA = "0x563430", Offset = "0x562230", VA = "0x10563430", Slot = "6")]
    public virtual void Clear()
    {
    }

    [Token(Token = "0x60092DA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
    public virtual void Update()
    {
    }

    [Token(Token = "0x60092DB")]
    [Address(RVA = "0x5635F0", Offset = "0x5623F0", VA = "0x105635F0", Slot = "8")]
    public virtual ContentNode Instantiate(ContentNode res) => (ContentNode) null;

    [Token(Token = "0x60092DC")]
    [Address(RVA = "0x5636B0", Offset = "0x5624B0", VA = "0x105636B0")]
    public void SetTable(ContentSource.Param[] values)
    {
    }

    [Token(Token = "0x60092DD")]
    [Address(RVA = "0x5634D0", Offset = "0x5622D0", VA = "0x105634D0", Slot = "9")]
    public virtual ContentSource.Param GetParam(int index) => (ContentSource.Param) null;

    [Token(Token = "0x60092DE")]
    [Address(RVA = "0x563500", Offset = "0x562300", VA = "0x10563500", Slot = "10")]
    public virtual ContentSource.Param GetParam(string value) => (ContentSource.Param) null;

    [Token(Token = "0x60092DF")]
    [Address(RVA = "0x5634B0", Offset = "0x5622B0", VA = "0x105634B0", Slot = "11")]
    public virtual int GetCount() => new int();

    [Token(Token = "0x60092E0")]
    [Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")]
    public ContentController GetContentController() => (ContentController) null;

    [Token(Token = "0x60092E1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ContentSource()
    {
    }

    [Token(Token = "0x200225D")]
    public class Param
    {
      [Token(Token = "0x40098BD")]
      [FieldOffset(Offset = "0x8")]
      private int _id;
      [Token(Token = "0x40098BE")]
      [FieldOffset(Offset = "0xC")]
      private int _idprev;

      [Token(Token = "0x170014A2")]
      public int id
      {
        [Token(Token = "0x60092E2"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] set
        {
        }
        [Token(Token = "0x60092E3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60092E4")]
      [Address(RVA = "0x57AA30", Offset = "0x579830", VA = "0x1057AA30")]
      public void Wakeup()
      {
      }

      [Token(Token = "0x60092E5")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public virtual void Initialize(ContentSource source)
      {
      }

      [Token(Token = "0x60092E6")]
      [Address(RVA = "0x57AA20", Offset = "0x579820", VA = "0x1057AA20", Slot = "5")]
      public virtual void Release()
      {
      }

      [Token(Token = "0x60092E7")]
      [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "6")]
      public virtual bool IsValid() => new bool();

      [Token(Token = "0x60092E8")]
      [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "7")]
      public virtual bool IsLock() => new bool();

      [Token(Token = "0x60092E9")]
      [Address(RVA = "0x57AA00", Offset = "0x579800", VA = "0x1057AA00", Slot = "8")]
      public virtual bool IsReMake() => new bool();

      [Token(Token = "0x60092EA")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "9")]
      public virtual void Update()
      {
      }

      [Token(Token = "0x60092EB")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "10")]
      public virtual void LateUpdate()
      {
      }

      [Token(Token = "0x60092EC")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "11")]
      public virtual void OnSetup(ContentNode node)
      {
      }

      [Token(Token = "0x60092ED")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "12")]
      public virtual void OnEnable(ContentNode node)
      {
      }

      [Token(Token = "0x60092EE")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "13")]
      public virtual void OnDisable(ContentNode node)
      {
      }

      [Token(Token = "0x60092EF")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "14")]
      public virtual void OnViewIn(ContentNode node, Vector2 pivotViewPosition)
      {
      }

      [Token(Token = "0x60092F0")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "15")]
      public virtual void OnViewOut(ContentNode node, Vector2 pivotViewPosition)
      {
      }

      [Token(Token = "0x60092F1")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "16")]
      public virtual void OnPageFit(ContentNode node)
      {
      }

      [Token(Token = "0x60092F2")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "17")]
      public virtual void OnSelectOn(ContentNode node)
      {
      }

      [Token(Token = "0x60092F3")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "18")]
      public virtual void OnSelectOff(ContentNode node)
      {
      }

      [Token(Token = "0x60092F4")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "19")]
      public virtual void OnClick(ContentNode node)
      {
      }

      [Token(Token = "0x60092F5")]
      [Address(RVA = "0x57A9D0", Offset = "0x5797D0", VA = "0x1057A9D0", Slot = "20")]
      public virtual bool Equal(string value) => new bool();

      [Token(Token = "0x60092F6")]
      [Address(RVA = "0x56B2A0", Offset = "0x56A0A0", VA = "0x1056B2A0")]
      public Param()
      {
      }
    }
  }
}
