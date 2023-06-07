Enemy Steve = new Enemy("Steve");
Attack Taxes = new Attack("Taxes", 15);
Attack CalculatorThrow = new Attack("Calculator Throw!", 10);
Attack Flail = new Attack("flail", 5);

Steve.AttackList.Add(Taxes);
Steve.AttackList.Add(CalculatorThrow);
Steve.AttackList.Add(Flail);

Steve.RandomAttack();