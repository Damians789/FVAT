# FVAT
Program wirrten during classes to generate FVAT based on products in the basket

After shopping in the online store, the customer will be sent a VAT invoice to the e-mail address provided. Your task is to write a logic that, based on the contents of the shopping cart / products, will generate data for a VAT invoice, such as:

     Invoice items, each item should consist of:
         product names
         Quantity of ordered goods
         Net unit price
         Net item prices (unit price times quantity)
         VAT
         Calculated gross price
     Total invoice value (sum of gross prices from all items)
     Customer/seller details:
         company name
         Address
         Number nip
         Bank account (seller)
     Generated invoice number
     Document issue date
     Sale date
     date of payment
     
The program was written in accordance with the Test Driven Design technique, so before creating a class, you first need to write unit tests for it
