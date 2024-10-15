// Decompiled with JetBrains decompiler
// Type: SRPG.StatusCoefficientParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D52")]
  public class StatusCoefficientParam
  {
    [Token(Token = "0x4007367")]
    [FieldOffset(Offset = "0x8")]
    private float mHP;
    [Token(Token = "0x4007368")]
    [FieldOffset(Offset = "0xC")]
    private float mAttack;
    [Token(Token = "0x4007369")]
    [FieldOffset(Offset = "0x10")]
    private float mDefense;
    [Token(Token = "0x400736A")]
    [FieldOffset(Offset = "0x14")]
    private float mMagAttack;
    [Token(Token = "0x400736B")]
    [FieldOffset(Offset = "0x18")]
    private float mMagDefense;
    [Token(Token = "0x400736C")]
    [FieldOffset(Offset = "0x1C")]
    private float mDex;
    [Token(Token = "0x400736D")]
    [FieldOffset(Offset = "0x20")]
    private float mSpeed;
    [Token(Token = "0x400736E")]
    [FieldOffset(Offset = "0x24")]
    private float mCritical;
    [Token(Token = "0x400736F")]
    [FieldOffset(Offset = "0x28")]
    private float mLuck;
    [Token(Token = "0x4007370")]
    [FieldOffset(Offset = "0x2C")]
    private float mCombo;
    [Token(Token = "0x4007371")]
    [FieldOffset(Offset = "0x30")]
    private float mMove;
    [Token(Token = "0x4007372")]
    [FieldOffset(Offset = "0x34")]
    private float mJump;

    [Token(Token = "0x17000FEB")]
    public float HP
    {
      [Token(Token = "0x6007817"), Address(RVA = "0x3A3960", Offset = "0x3A2760", VA = "0x103A3960")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FEC")]
    public float Attack
    {
      [Token(Token = "0x6007818"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FED")]
    public float Defense
    {
      [Token(Token = "0x6007819"), Address(RVA = "0x2CD710", Offset = "0x2CC510", VA = "0x102CD710")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FEE")]
    public float MagAttack
    {
      [Token(Token = "0x600781A"), Address(RVA = "0x2C72E0", Offset = "0x2C60E0", VA = "0x102C72E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FEF")]
    public float MagDefense
    {
      [Token(Token = "0x600781B"), Address(RVA = "0x3A3980", Offset = "0x3A2780", VA = "0x103A3980")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FF0")]
    public float Dex
    {
      [Token(Token = "0x600781C"), Address(RVA = "0x3A3950", Offset = "0x3A2750", VA = "0x103A3950")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FF1")]
    public float Speed
    {
      [Token(Token = "0x600781D"), Address(RVA = "0x3A3990", Offset = "0x3A2790", VA = "0x103A3990")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FF2")]
    public float Critical
    {
      [Token(Token = "0x600781E"), Address(RVA = "0x3A3940", Offset = "0x3A2740", VA = "0x103A3940")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FF3")]
    public float Luck
    {
      [Token(Token = "0x600781F"), Address(RVA = "0x2CD6D0", Offset = "0x2CC4D0", VA = "0x102CD6D0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FF4")]
    public float Combo
    {
      [Token(Token = "0x6007820"), Address(RVA = "0x3A3930", Offset = "0x3A2730", VA = "0x103A3930")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FF5")]
    public float Move
    {
      [Token(Token = "0x6007821"), Address(RVA = "0x2A2960", Offset = "0x2A1760", VA = "0x102A2960")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FF6")]
    public float Jump
    {
      [Token(Token = "0x6007822"), Address(RVA = "0x3A3970", Offset = "0x3A2770", VA = "0x103A3970")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6007823")]
    [Address(RVA = "0x3A38D0", Offset = "0x3A26D0", VA = "0x103A38D0")]
    public void Deserialize(JSON_StatusCoefficientParam json)
    {
    }

    [Token(Token = "0x6007824")]
    [Address(RVA = "0x3A3340", Offset = "0x3A2140", VA = "0x103A3340")]
    public static int CalcTotalStatus(UnitData unit) => new int();

    [Token(Token = "0x6007825")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public StatusCoefficientParam()
    {
    }
  }
}
