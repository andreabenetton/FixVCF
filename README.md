# FixVCF
ProtonMail to LineageOS vcf fixer

A simple windows app to convert a contact in a format that is importable by Simple Contact app on F-Droid.

Take note of the fact that if you have previously merged contacts on Protonmail, in the vcf there will be multiple FN items for the same contacts. You have to fix this by doing a search of "FN" in the exported file and going back in protoncontacts to update to "" blank space the name of the contacts, even multiple time if more than 2 FN. At last you have update again with the right name+surname.

The app will remove spaces in phone number to let Signal app resolve the address. It set the type of number to "phone" letting android normal app to show number correctly. Also will remove email only contact and to others it will remove email address for security reason (not needed on phone). 

Look for ButtonProcess_Click in MainForm.cs to customize the app for your needs.ù

