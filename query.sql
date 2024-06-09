SELECT 
p.id AS product_id,
p.name AS product_name,
c.id AS category_id,
c.name AS category_name
FROM main.product p 
LEFT JOIN main.product_category pc ON p.id = pc.product_id
LEFT JOIN main.category c ON pc.category_id = c.id;