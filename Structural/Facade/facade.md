# Facade Design Pattern

## Facade Design Pattern states that you need to provide a unified interface to a set of interfaces in a subsystem. 
## The Facade Design Pattern defines a higher-level interface that makes the subsystem easier to use.



CLIENT ->   ORDER
              |
  ↓           ↓            ↓
PRODUCT     PAYMENT      INVOICE



CLIENT ->          FACADE
                     |
    ↓                    ↓                    ↓
SUB-SYSTEM 1     SUB-SYSTEM 1  . . .  SUB-SYSTEM N

